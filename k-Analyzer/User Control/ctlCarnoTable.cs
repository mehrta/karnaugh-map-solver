using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using K_Analyzer.Types;

namespace K_Analyzer.UserControls
{
    public partial class ctlKarnaughTable : UserControl
    {
        public enum EColorMode { Default, Mode1, Mode2, Mode3 }

        // Fields
        private CKarnaughTable m_objKarnaugh;

        private int m_frameThickness = 2;
        private int m_rowsCount = 4;
        private const int m_colsCount = 4;
        private bool m_updateGUI = true; // if it's 'True' control will be redraw after change graphical properties 
        private bool m_specifyGroupsVisualy = true;
        private bool m_showLables = true;
        private bool m_showValue0 = false;
        private bool m_showValue1 = true;
        private bool m_showMintermsIndex = true;
        private string[] m_strLableBits_Rows;
        private string[] m_strLableBits_Cols;

        private Rectangle m_innerTableRegion; // Region of table's frame
        private Rectangle[] m_cellsLocation_Hor; // A array for store horizontal cells locations
        private Rectangle[] m_cellsLocation_Ver; // A array for store vertical cells locations
        private Size m_lableBitsSize;
        private Size m_lableSize;

        private SolidBrush m_generalBrush;
        private Pen m_borderPen;
        private Pen m_framePen;
        private Pen m_bracketPen;
        private Pen m_groupSpecifyerPen;
        private int m_colorAlpha = 100;

        private Color m_groupSpecifyerColor = Color.FromArgb(100, Color.Red);
        private Color m_frameColor = Color.Black;
        private Color m_lableColor = Color.Blue;
        private Color m_lableBitsColor = Color.DarkGreen;
        private Color m_bracketColor = Color.Black;
        private Color m_borderColor = Color.Gray;

        private Color m_mintermValueColor = Color.DarkGreen;
        private Color m_mintermIndexColor = Color.Black;

        private Font m_mintermValueFont;
        private Font m_mintemIndexFont;
        private Font m_lableBitsFont;
        private Font m_lableFont;

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


        #region User Defined Methods

        public ctlKarnaughTable()
        {
            InitializeComponent();

            m_cellsLocation_Hor = new Rectangle[4];
            m_cellsLocation_Ver = new Rectangle[4];

            m_strLableBits_Rows = new string[4] { "00", "01", "11", "10" };
            m_strLableBits_Cols = new string[4] { "00", "01", "11", "10" };

            // Initialize graphical objects for drawing
            m_framePen = new Pen(m_frameColor, m_frameThickness);
            m_bracketPen = new Pen(m_bracketColor, 2);
            m_borderPen = new Pen(Color.Black, 1);
            m_groupSpecifyerPen = new Pen(m_groupSpecifyerColor, 3);

            m_mintemIndexFont = new Font("Arial", 10);
            m_mintermValueFont = new Font("Arial", 12);

            m_generalBrush = new SolidBrush(Color.Black);

            //

            TableLocation = new Point(40, 40);
            LableFont = new Font("Arial", 10);
            LableBitFont = new Font("Arial", 8);
        }

        public void KarnaughTableObject(CKarnaughTable newObject)
        {
            if (newObject.GetTableType() == EKarnaughTableType.Karnaugh3Var)
            {
                // 3 var table
                m_rowsCount = 2;
                m_strLableBits_Rows[0] = "0";
                m_strLableBits_Rows[1] = "1";

            }
            else
            {
                // 4 var table
                m_rowsCount = 4;
                m_strLableBits_Rows[0] = "00";
                m_strLableBits_Rows[1] = "01";
            }


            m_objKarnaugh = newObject;
            CalculateCellsLocation();
            this.Invalidate();
        }

        public void ApplyColorMode(EColorMode colorMode)
        {
            bool tmpBool = m_updateGUI;

            // We must not update GUI (for more Performance)
            m_updateGUI = false;

            switch (colorMode)
            {
                case EColorMode.Mode1:
                    BracketColor = Color.Black;
                    FrameColor = Color.Black;
                    GroupSpecifyerColor = Color.LimeGreen;
                    LableBitsColor = Color.DarkGreen;
                    LableColor = Color.Gray;
                    MintermIndexColor = Color.Black;
                    MintermValueColor = Color.Black;
                    break;
                case EColorMode.Mode2:
                    BracketColor = Color.Red;
                    FrameColor = Color.Blue;
                    GroupSpecifyerColor = Color.Red;
                    LableBitsColor = Color.Black;
                    LableColor = Color.Blue;
                    MintermIndexColor =  Color.Blue;
                    MintermValueColor = Color.Blue;
                    break;
                case EColorMode.Mode3:
                    BracketColor = Color.Black;
                    FrameColor = Color.Lime;
                    GroupSpecifyerColor = Color.Magenta;
                    LableBitsColor = Color.Black;
                    LableColor = Color.Black;
                    MintermIndexColor = Color.Black;
                    MintermValueColor = Color.Black;
                    break;
                case EColorMode.Default:
                    BracketColor = Color.Silver;
                    FrameColor = Color.Green;
                    GroupSpecifyerColor = Color.Blue;
                    LableBitsColor = Color.Gray;
                    LableColor = Color.Blue;
                    MintermIndexColor = Color.Gray;
                    MintermValueColor = Color.Green;
                    break;
            }
            m_updateGUI = tmpBool;
            this.Invalidate();
        }

        public Rectangle GetCellLocation(int row, int col)
        {
            return new Rectangle(m_cellsLocation_Hor[col].Left, m_cellsLocation_Ver[row].Top,
                m_cellsLocation_Hor[col].Width, m_cellsLocation_Ver[row].Height);
        }

        private void CalculateCellsLocation()
        {
            float cellWidth, cellHeight;

            #region Calculate cells location and put they in array

            // Get width and height of cells
            cellWidth = (float)m_innerTableRegion.Width / m_colsCount;
            cellHeight = (float)m_innerTableRegion.Height / m_rowsCount;
            //

            // // // // // // Calculations
            // Horizontal locations
            m_cellsLocation_Hor[0].X = m_innerTableRegion.Left;
            m_cellsLocation_Hor[0].Width = (int)cellWidth;
            for (int i = 1; i < m_colsCount; i++)
            {
                m_cellsLocation_Hor[i].X = m_cellsLocation_Hor[i - 1].Right;
                m_cellsLocation_Hor[i].Width = (int)(cellWidth * (i + 1) + m_innerTableRegion.Left) - m_cellsLocation_Hor[i].Left;
            }

            // Vertical locations
            m_cellsLocation_Ver[0].Y = m_innerTableRegion.Top;
            m_cellsLocation_Ver[0].Height = (int)cellHeight;
            for (int i = 1; i < m_rowsCount; i++)
            {
                m_cellsLocation_Ver[i].Y = m_cellsLocation_Ver[i - 1].Bottom;
                m_cellsLocation_Ver[i].Height = (int)(cellHeight * (i + 1) + m_innerTableRegion.Top) - m_cellsLocation_Ver[i].Top;
            }
            // // // // // //
            //m_cellsLocation_Ver[3].Height -= 10;
            #endregion
        }

        private Rectangle[] GetGroupRegions(SKarnaughGroup group)
        {
            Rectangle[] reg;

            if (group.Type == EGroupTypes.RectGroup_4 && group.Location == 10)
            {
                #region We must return 4 region
                reg = new Rectangle[4];
                reg[0] = GetMintermLocation(0);
                reg[1] = GetMintermLocation(2);
                reg[2] = GetMintermLocation(8);
                reg[3] = GetMintermLocation(10);

                #endregion
            }
            else if ((group.Location % 4 == 2 && (group.Type == EGroupTypes.LinerGroup_2_Hor ||
                                             group.Type == EGroupTypes.RectGroup_4 ||
                                             group.Type == EGroupTypes.RectGroup_8_Ver))
              || ((group.Location >= 8 && group.Location <= 11) && (group.Type == EGroupTypes.LinerGroup_2_Ver ||
                                                                    group.Type == EGroupTypes.RectGroup_4 ||
                                                                    group.Type == EGroupTypes.RectGroup_8_Hor)))
            {
                #region We must return 2 region
                reg = new Rectangle[2];
                SKarnaughGroup g1, g2;
                Rectangle[] reg1;
                Rectangle[] reg2;
                switch (group.Type)
                {
                    case EGroupTypes.RectGroup_8_Ver:
                        g1.Type = g2.Type = EGroupTypes.LinerGroup_4_Ver;
                        g1.Location = 0;
                        g2.Location = 2;

                        reg1 = GetGroupRegions(g1);
                        reg2 = GetGroupRegions(g2);

                        reg[0] = reg1[0];
                        reg[1] = reg2[0];
                        break;

                    case EGroupTypes.RectGroup_8_Hor:
                        g1.Type = g2.Type = EGroupTypes.LinerGroup_4_Hor;
                        g1.Location = 0;
                        g2.Location = 8;

                        reg1 = GetGroupRegions(g1);
                        reg2 = GetGroupRegions(g2);

                        reg[0] = reg1[0];
                        reg[1] = reg2[0];
                        break;

                    case EGroupTypes.RectGroup_4:
                        if (group.Location == 2 || group.Location == 6 || group.Location == 14)
                        {
                            g1.Type = g2.Type = EGroupTypes.LinerGroup_2_Ver;
                            g1.Location = group.Location - 2;
                            g2.Location = group.Location;

                            reg1 = GetGroupRegions(g1);
                            reg2 = GetGroupRegions(g2);

                            reg[0] = reg1[0];
                            reg[1] = reg2[0];
                        }
                        else if (group.Location == 8 || group.Location == 9 || group.Location == 11)
                        {
                            g1.Type = g2.Type = EGroupTypes.LinerGroup_2_Hor;
                            g1.Location = group.Location - 8;
                            g2.Location = group.Location;

                            reg1 = GetGroupRegions(g1);
                            reg2 = GetGroupRegions(g2);

                            reg[0] = reg1[0];
                            reg[1] = reg2[0];

                        }

                        break;

                    case EGroupTypes.LinerGroup_2_Hor:
                        g1.Type = g2.Type = EGroupTypes.SingleMinterm;
                        g1.Location = group.Location - 2;
                        g2.Location = group.Location;

                        reg1 = GetGroupRegions(g1);
                        reg2 = GetGroupRegions(g2);

                        reg[0] = reg1[0];
                        reg[1] = reg2[0];
                        break;

                    case EGroupTypes.LinerGroup_2_Ver:
                        g1.Type = g2.Type = EGroupTypes.SingleMinterm;
                        g1.Location = group.Location - 8;
                        g2.Location = group.Location;

                        reg1 = GetGroupRegions(g1);
                        reg2 = GetGroupRegions(g2);

                        reg[0] = reg1[0];
                        reg[1] = reg2[0];
                        break;
                }
                #endregion
            }
            else
            {
                #region We must return 1 region
                Rectangle currentRegion;
                int[] mintermIndexes = CKarnaughTable.GetMintermsIndexes(CKarnaughTable.GetMintermsInsideGroup(group));
                int regionsCount = mintermIndexes.GetLength(0);
                reg = new Rectangle[1];

                reg[0] = GetMintermLocation(mintermIndexes[0]);
                for (int i = 1; i < regionsCount; i++)
                {
                    currentRegion = GetMintermLocation(mintermIndexes[i]);
                    if (currentRegion.Left < reg[0].Left)
                        reg[0].X = currentRegion.Left;
                    if (currentRegion.Top < reg[0].Top)
                        reg[0].Y = currentRegion.Top;
                    if (currentRegion.Right > reg[0].Right)
                        reg[0].Width = currentRegion.Right - reg[0].Left;
                    if (currentRegion.Bottom > reg[0].Bottom)
                        reg[0].Height = currentRegion.Bottom - reg[0].Top;
                }
                #endregion

            }


            return reg;
        }

        private void SpecifyGroupVisualy(SKarnaughGroup group, Graphics g)
        {
            Point[] points1;
            Point[] points2;
            Point[] points3;
            Point[] points4;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            Rectangle[] drawRegions = GetGroupRegions(group);
            int drawRegionsCount = drawRegions.GetLength(0);
            int Spc_HOR = 20;
            int Spc_VER = 15;
            int Dest_To_Reg = m_innerTableRegion.Left / 2;

            if (drawRegionsCount == 1)
            {
                points1 = new Point[2];
                int middle_X = (drawRegions[0].Left + drawRegions[0].Right) / 2;
                Spc_HOR = 10;
                Spc_VER = 10;

                #region Set rectangular shape points (for around a cell)

                points1[0].X = drawRegions[0].Left + Spc_HOR;
                points1[0].Y = drawRegions[0].Top + Spc_VER;

                points1[1].X = drawRegions[0].Right - Spc_HOR;
                points1[1].Y = drawRegions[0].Bottom - Spc_VER;
                #endregion

                path.AddEllipse(points1[0].X, points1[0].Y, points1[1].X - points1[0].X, points1[1].Y - points1[0].Y);
                path.StartFigure();
            }
            else if (drawRegionsCount == 2)
            {
                points1 = new Point[4];
                points2 = new Point[4];

                #region Set curve points (for around two groups)

                if (drawRegions[0].Left == drawRegions[1].Left)
                {
                    // We have two HORIZONTAL group
                    #region Set top group points

                    points1[0].X = drawRegions[0].Left + Spc_HOR;
                    points1[0].Y = m_innerTableRegion.Top - Dest_To_Reg;

                    points1[1].X = (int)(drawRegions[0].Left + Spc_HOR);
                    points1[1].Y = (int)(drawRegions[0].Bottom - Spc_VER);

                    points1[2].X = (int)(drawRegions[0].Right - Spc_HOR);
                    points1[2].Y = points1[1].Y;

                    points1[3].X = points1[2].X;
                    points1[3].Y = points1[0].Y;
                    #endregion

                    #region Set bottom group points
                    points2[0].X = points1[0].X;
                    points2[0].Y = drawRegions[1].Bottom + Dest_To_Reg;

                    points2[1].X = points1[1].X;
                    points2[1].Y = (int)(drawRegions[1].Top + Spc_VER);

                    points2[2].X = points1[2].X;
                    points2[2].Y = points2[1].Y;

                    points2[3].X = points1[3].X;
                    points2[3].Y = points2[0].Y;
                    #endregion

                }
                else
                {
                    // We have two VERTICAL group

                    #region Set left group points

                    points1[0].X = m_innerTableRegion.Left - Dest_To_Reg;
                    points1[0].Y = drawRegions[0].Top + Spc_VER;

                    points1[1].X = (int)(drawRegions[0].Right - Spc_HOR);
                    points1[1].Y = (int)(drawRegions[0].Top + Spc_VER);

                    points1[2].X = points1[1].X;
                    points1[2].Y = (int)(drawRegions[0].Bottom - Spc_VER);

                    points1[3].X = points1[0].X;
                    points1[3].Y = drawRegions[0].Bottom - Spc_VER;
                    #endregion


                    #region Set right group points

                    points2[0].X = m_innerTableRegion.Right + Dest_To_Reg;
                    points2[0].Y = points1[0].Y;

                    points2[1].X = (int)(drawRegions[1].Left + Spc_HOR);
                    points2[1].Y = points1[1].Y;

                    points2[2].X = points2[1].X;
                    points2[2].Y = points1[2].Y;

                    points2[3].X = points2[0].X;
                    points2[3].Y = points1[2].Y;
                    #endregion
                }
                #endregion

                path.AddCurve(points1, 0.2f);
                path.StartFigure();
                path.AddCurve(points2, 0.2f);
            }
            else
            {
                points1 = new Point[3];
                points2 = new Point[3];
                points3 = new Point[3];
                points4 = new Point[3];

                #region Set curve points (for around four groups)

                // Group 1
                points1[0].X = m_innerTableRegion.Left - Dest_To_Reg;
                points1[0].Y = drawRegions[0].Bottom - Spc_VER;

                points1[1].X = drawRegions[0].Right - Spc_HOR;//drawRegions[0].Right- Spc_HOR ;
                points1[1].Y = drawRegions[0].Bottom - Spc_VER;//points1[0].Y;

                points1[2].X = drawRegions[0].Right - Spc_HOR;
                points1[2].Y = m_innerTableRegion.Top - Dest_To_Reg;

                // Group 2
                points2[0].X = drawRegions[1].Right + Dest_To_Reg;
                points2[0].Y = points1[0].Y;

                points2[1].X = drawRegions[1].Left + Spc_HOR;
                points2[1].Y = points1[1].Y;

                points2[2].X = drawRegions[1].Left + Spc_HOR;
                points2[2].Y = points1[2].Y;

                // Group 3
                points3[0].X = points1[0].X;
                points3[0].Y = drawRegions[2].Top + Spc_VER;

                points3[1].X = points1[1].X;
                points3[1].Y = drawRegions[2].Top + Spc_VER;

                points3[2].X = points1[2].X;
                points3[2].Y = drawRegions[2].Bottom + Dest_To_Reg;

                // Group 4
                points4[0].X = points2[0].X;
                points4[0].Y = points3[0].Y;

                points4[1].X = points2[1].X;
                points4[1].Y = points3[1].Y;

                points4[2].X = points2[2].X;
                points4[2].Y = points3[2].Y;
                #endregion

                path.AddCurve(points1);
                path.StartFigure();
                path.AddCurve(points2);
                path.StartFigure();
                path.AddCurve(points3);
                path.StartFigure();
                path.AddCurve(points4);

            }

            // Draw with high quality
            g.DrawPath(m_groupSpecifyerPen, path);
            //
        }

        private Rectangle GetMintermLocation(int mintermIndex)
        {
            int row = -1, col = -1;

            if (mintermIndex >= 0 && mintermIndex <= 3)
                row = 0;
            else if (mintermIndex >= 4 && mintermIndex <= 7)
                row = 1;
            else if (mintermIndex >= 8 && mintermIndex <= 11)
                row = 3;
            else // mintermIndex>=12 && mintermIndex<=15
                row = 2;

            switch (mintermIndex % 4)
            {
                case 0:
                    col = 0;
                    break;
                case 1:
                    col = 1;
                    break;
                case 2:
                    col = 3;
                    break;
                case 3:
                    col = 2;
                    break;
            }


            return GetCellLocation(row, col);
        }
        #endregion


        #region User Defined Properties

        public bool UpdateGUI
        {
            set
            {
                m_updateGUI = value;
                if (value) this.Invalidate();
            }
            get
            {
                return m_updateGUI;
            }
        }

        public bool ShowMintermsIndex
        {
            set
            {
                m_showMintermsIndex = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_showMintermsIndex;
            }
        }

        public bool ShowValue0
        {
            set
            {
                m_showValue0 = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_showValue0;
            }
        }

        public bool ShowValue1
        {
            set
            {
                m_showValue1 = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_showValue1;
            }
        }

        public bool SpecifyFunctionGroupsVisualy
        {
            set
            {
                m_specifyGroupsVisualy = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_specifyGroupsVisualy;
            }
        }

        public bool ShowLables
        {
            set
            {
                m_showLables = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_showLables;
            }
        }

        public Point TableLocation
        {
            set
            {
                m_innerTableRegion.X = value.X;
                m_innerTableRegion.Y = value.Y;
                m_innerTableRegion.Width = this.Width - value.X * 2;
                m_innerTableRegion.Height = this.Height - value.Y * 2;
                CalculateCellsLocation();
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_innerTableRegion.Location;
            }
        }

        public Font LableBitFont
        {
            set
            {
                m_lableBitsFont = value;
                m_lableBitsSize = TextRenderer.MeasureText("__", value);
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_lableBitsFont;
            }
        }

        public Font LableFont
        {
            set
            {
                m_lableFont = value;
                m_lableSize = TextRenderer.MeasureText("_", value);
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_lableFont;
            }
        }

        public Font ValueFont
        {
            set
            {
                m_mintermValueFont = value;
                if (m_updateGUI) this.Validate();
            }
            get
            {
                return m_mintermValueFont;
            }
        }

        public Font IndexFont
        {
            set
            {
                m_mintemIndexFont = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_mintemIndexFont;
            }
        }

        public Color GroupSpecifyerColor
        {
            set
            {
                m_groupSpecifyerColor = Color.FromArgb(m_colorAlpha, value);
                m_groupSpecifyerPen.Color = m_groupSpecifyerColor;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_groupSpecifyerColor;
            }
        }

        public Color LableColor
        {
            set
            {
                m_lableColor = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_lableColor;
            }
        }

        public Color LableBitsColor
        {
            set
            {
                m_lableBitsColor = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_lableBitsColor;
            }
        }

        public Color FrameColor
        {
            set
            {
                m_frameColor = value;
                m_framePen.Color = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_frameColor;
            }
        }

        public Color BracketColor
        {
            set
            {
                m_bracketColor = value;
                m_bracketPen.Color = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_bracketColor;
            }
        }

        public Color MintermValueColor
        {
            set
            {
                m_mintermValueColor = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_mintermValueColor;
            }
        }

        public Color MintermIndexColor
        {
            set
            {
                m_mintermIndexColor = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_mintermIndexColor;
            }
        }

        public Color BorderColor
        {
            set
            {
                m_borderColor = value;
                if (m_updateGUI) this.Invalidate();
            }
            get
            {
                return m_borderColor;
            }
        }

        public int ColorAlpha
        {
            set
            {
                if (value > 0 && value <= 255)
                {
                    m_colorAlpha = value;
                    m_groupSpecifyerColor = Color.FromArgb(value, m_groupSpecifyerColor);
                    m_groupSpecifyerPen.Color = m_groupSpecifyerColor;
                    if (m_updateGUI) this.Invalidate();
                }
                else
                {
                    ColorAlpha = m_colorAlpha;
                }
            }
            get
            {
                return m_colorAlpha;
            }
        }

        #endregion


        #region UserControl events

        private void ctlKarnaughTable_Load(object sender, EventArgs e)
        {
            // Draw with high quality

            // Enable Double Buffering for this control
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void ctlKarnaughTable_SizeChanged(object sender, EventArgs e)
        {
            CalculateCellsLocation();
            this.TableLocation = this.TableLocation;

            this.Invalidate();
        }

        private void ctlKarnaughTable_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point point1 = new Point();
            Point point2 = new Point();
            Point point3 = new Point();
            int mintermsCount = 16;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (m_objKarnaugh == null)
                mintermsCount = 16;
            else if (m_objKarnaugh.GetTableType() == EKarnaughTableType.Karnaugh3Var)
                mintermsCount = 8;


            #region Draw Table Border
            m_borderPen.Color = m_borderColor;
            g.DrawRectangle(m_borderPen, new Rectangle(new Point(0, 0), new System.Drawing.Size(this.Width - 1, this.Height - 1)));
            #endregion

            #region Draw Table Frame
            int X1 = m_innerTableRegion.Left;
            int Y1 = m_innerTableRegion.Top;
            int X2 = m_innerTableRegion.Right;
            int Y2 = m_innerTableRegion.Bottom;

            // Draw rows
            int currentCellBottom;
            g.DrawLine(m_framePen, X1, Y1, X2, Y1);
            for (int i = 0; i < m_rowsCount; i++)
            {
                currentCellBottom = GetCellLocation(i, 0).Bottom;
                g.DrawLine(m_framePen, X1, currentCellBottom, X2, currentCellBottom);
            }

            // Draw cols
            int currentCellRight;
            g.DrawLine(m_framePen, X1, Y1, X1, Y2);
            for (int i = 0; i < m_colsCount; i++)
            {
                currentCellRight = GetCellLocation(0, i).Right;
                g.DrawLine(m_framePen, currentCellRight, Y1, currentCellRight, Y2);
            }

            #endregion

            if (ShowMintermsIndex)
            {
                #region Draw Minterm Indexses

                for (int i = 0; i < mintermsCount; i++)
                {
                    // Draw minterm indexes in cells
                    point1 = GetMintermLocation(i).Location;
                    TextRenderer.DrawText(g, i.ToString(), m_mintemIndexFont, point1, m_mintermIndexColor);
                }
                #endregion
            }

            if (ShowLables)
            {
                #region Draw lables

                const int SPC = 5;
                char[] chrLetters;
                char chr;

                #region Draw binary lables

                for (int i = 0; i < m_colsCount; i++)
                {
                    point1.X = m_cellsLocation_Hor[i].Left + (m_cellsLocation_Hor[i].Width - m_lableBitsSize.Width) / 2;
                    point1.Y = m_innerTableRegion.Top - m_lableBitsSize.Height;
                    TextRenderer.DrawText(g, m_strLableBits_Cols[i], m_lableBitsFont, point1, m_lableBitsColor);
                }

                for (int i = 0; i < m_rowsCount; i++)
                {
                    point1.X = m_innerTableRegion.Left - m_lableBitsSize.Width;
                    point1.Y = m_cellsLocation_Ver[i].Top + (m_cellsLocation_Ver[i].Height - m_lableBitsSize.Height) / 2; ;
                    TextRenderer.DrawText(g, m_strLableBits_Rows[i], m_lableBitsFont, point1, m_lableBitsColor);
                }


                #endregion

                #region Draw brackets && table letters

                if (m_objKarnaugh == null)
                    chrLetters = new char[4] { 'A', 'B', 'C', 'D' };
                else
                    chrLetters = m_objKarnaugh.TableLetters;

                // Bracket for letter A
                point1.X = m_innerTableRegion.Left - m_lableBitsSize.Width - SPC;
                point1.Y = (m_innerTableRegion.Top + m_innerTableRegion.Bottom) / 2;
                point2.X = point1.X;
                point2.Y = m_innerTableRegion.Bottom;
                g.DrawLine(m_bracketPen, point1, point2);

                point3.X = point1.X - m_lableSize.Width;
                point3.Y = (point2.Y + point1.Y - m_lableSize.Height) / 2;
                TextRenderer.DrawText(g, chrLetters[0].ToString(), m_lableFont, point3, m_lableColor);


                // Bracket for letter C
                point1.X = m_cellsLocation_Hor[2].Left;
                point1.Y = m_innerTableRegion.Top - m_lableBitsSize.Height - SPC;
                point2.X = m_cellsLocation_Hor[3].Right;
                point2.Y = point1.Y;
                g.DrawLine(m_bracketPen, point1, point2);

                point3.X = (point2.X + point1.X - m_lableSize.Width) / 2;
                point3.Y = point1.Y - m_lableSize.Height;
                chr = m_rowsCount == 2 ? chrLetters[1] : chrLetters[2];
                TextRenderer.DrawText(g, chr.ToString(), m_lableFont, point3, m_lableColor);



                // Bracket for letter D
                point1.X = m_cellsLocation_Hor[1].Left;
                point1.Y = m_innerTableRegion.Bottom + SPC * 2;
                point2.X = m_cellsLocation_Hor[3].Left;
                point2.Y = point1.Y;
                g.DrawLine(m_bracketPen, point1, point2);

                point3.X = (point1.X + point2.X - m_lableSize.Width) / 2;
                point3.Y = point2.Y;
                chr = m_rowsCount == 2 ? chrLetters[2] : chrLetters[3];
                TextRenderer.DrawText(g, chr.ToString(), m_lableFont, point3, m_lableColor);

                if (m_rowsCount == 4)
                {
                    // Bracket for letter B
                    point1.X = m_innerTableRegion.Right + SPC * 2;
                    point1.Y = m_cellsLocation_Ver[1].Top;
                    point2.X = point1.X;
                    point2.Y = m_cellsLocation_Ver[3].Top;
                    g.DrawLine(m_bracketPen, point1, point2);

                    point3.X = point2.X + SPC;
                    point3.Y = (point2.Y + point1.Y - m_lableSize.Height) / 2;
                    TextRenderer.DrawText(g, chrLetters[1].ToString(), m_lableFont, point3, m_lableColor);
                }
                #endregion

                #region Draw DIAGONAL line && row and col headers

                point1.X = m_innerTableRegion.Left - 20;
                point1.Y = m_innerTableRegion.Top - 20;
                // Set location of col headers
                point2.X = point1.X - m_lableSize.Width;
                point2.Y = point1.Y + m_lableSize.Height / 2;
                // Set location of row headers
                point3.X = point1.X + m_lableSize.Width / 2;
                point3.Y = point1.Y - m_lableSize.Height / 2;

                g.DrawLine(m_framePen, point1, m_innerTableRegion.Location);

                TextRenderer.DrawText(g, chrLetters[0].ToString() + chrLetters[1].ToString(), m_lableFont, point2, m_lableColor);
                string strRowHeader = m_rowsCount == 2 ? chrLetters[2].ToString() : chrLetters[2].ToString() + chrLetters[3].ToString();
                TextRenderer.DrawText(g, strRowHeader, m_lableFont, point3, m_lableColor);

                #endregion
                #endregion
            }

            #region Draw minterm values  && Specify Groups Visualy

            if (m_objKarnaugh != null)
            {
                #region Draw minterm values
                string strBool = "0";
                Rectangle tmp;
                bool currentMintermValue;

                for (int i = 0; i < mintermsCount; i++)
                {
                    tmp = GetMintermLocation(i);
                    point1.X = tmp.Left + tmp.Width / 2 - 10;
                    point1.Y = tmp.Top + tmp.Height / 2 - 10;
                    currentMintermValue = m_objKarnaugh.GetMintermValue(i);

                    if (currentMintermValue && m_showValue1)
                    {
                        strBool = "1";
                        m_generalBrush.Color = m_mintermValueColor;
                        g.DrawString(strBool, m_mintermValueFont, m_generalBrush, point1);
                    }
                    else if (currentMintermValue == false && m_showValue0)
                    {
                        strBool = "0";
                        m_generalBrush.Color = Color.FromArgb(100, m_mintermValueColor);
                        g.DrawString(strBool, m_mintermValueFont, m_generalBrush, point1);
                    }

                }
                #endregion

                if (m_specifyGroupsVisualy)
                {
                    #region Specify Groups Visualy

                    SKarnaughGroup[] groups = m_objKarnaugh.GetFunctionGroups();
                    foreach (SKarnaughGroup group in groups)
                        SpecifyGroupVisualy(group, g);
                    #endregion
                }
            }
            else
            {
                // Show a group temprory (to help to developers to set color property of groups easily)
                SKarnaughGroup myGroup = new SKarnaughGroup();
                myGroup.Location = 0;
                myGroup.Type = EGroupTypes.SingleMinterm;

                SpecifyGroupVisualy(myGroup, g);
            }
            #endregion
        }
        #endregion
    }
}
