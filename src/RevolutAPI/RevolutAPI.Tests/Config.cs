﻿namespace RevolutAPI.Tests
{
    public class Config
    {
        public static readonly string ENDPOINT = "https://sandbox-b2b.revolut.com/api/1.0";
        public static readonly string TOKEN = "sand_your_key";

        // used in payments tests
        public static readonly string ACCOUNT_ID = "";

        public static readonly string COUNTERPARTY_ID = "";
        public static readonly string COUNTERPARTY_ACCOUNT_ID = "";

        // currency must match for both ACCOUNT_ID and COUNTERPARTY_ACCOUNT_ID
        public static readonly string CURRENCY = "EUR";
    }
}