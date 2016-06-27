namespace Gigobyte.Plaid.Contract
{
    public static class Extensions
    {
        public static MfaType AsMfaType(this string value)
        {
            switch ((value ?? string.Empty).ToLower())
            {
                case "questions":
                    return MfaType.Question;

                case "list":
                    return MfaType.Code;

                default:
                    return MfaType.None;
            }
        }
    }
}