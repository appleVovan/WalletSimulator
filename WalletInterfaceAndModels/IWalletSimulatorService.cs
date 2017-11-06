﻿using System.ServiceModel;
using WalletSimulator.Interface.Models;


namespace WalletSimulator.Interface
{
    [ServiceContract]
    public interface  IWalletSimulatorService
    {
        [OperationContract]
        bool UserExists(string login);
        [OperationContract]
        User GetUserByLogin(string login);
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void AddWallet(Wallet wallet);
        [OperationContract]
        void SaveWallet(Wallet wallet);
        [OperationContract]
        void AddTransaction(Transaction transaction);
    }
}
