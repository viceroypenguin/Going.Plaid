namespace Gigobyte.Plaid.Contract
{
    public static class Extensions
    {
        public static MfaType AsMfaType(this string value)
        {
            switch (value.ToLower())
            {
                case "questions":
                    return MfaType.Question;

                case "list":
                    return MfaType.Code;

                default:
                    throw new System.ArgumentException($"'{value}' is not a valid {nameof(MfaType)} enum value.", nameof(value));
            }
        }
    }
}