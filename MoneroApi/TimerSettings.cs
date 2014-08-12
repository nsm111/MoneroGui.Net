﻿namespace Jojatekok.MoneroAPI
{
    static class TimerSettings
    {
        public const int RpcCheckAvailabilityPeriod = 1000;
        public const int RpcCheckAvailabilityDueTime = 5000;

        public const int DaemonQueryNetworkInformationPeriod = 750;
        public const int DaemonSaveBlockchainPeriod = 360000;

        public const int AccountRefreshPeriod = 10000;
        public const int AccountSaveAccountPeriod = 120000;
    }
}