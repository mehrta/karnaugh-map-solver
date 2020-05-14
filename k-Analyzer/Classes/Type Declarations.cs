namespace K_Analyzer.Types
{
    public enum EKarnaughTableType
    {
        Karnaugh3Var , Karnaugh4Var
    }

    public enum EGroupTypes
    {
        RectGroup_16, RectGroup_8_Hor, RectGroup_8_Ver,
        RectGroup_4, LinerGroup_4_Hor, LinerGroup_4_Ver,
        LinerGroup_2_Hor, LinerGroup_2_Ver, SingleMinterm
    }

    public struct SKarnaughGroup
    {
        public EGroupTypes Type;
        public int Location;
    }

}



