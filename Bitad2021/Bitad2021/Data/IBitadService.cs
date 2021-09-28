﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bitad2021.Models;

namespace Bitad2021.Data
{
    public interface IBitadService
    {
        Task<User> Login(string login, string password);
        User LoginSync(string username, string password);
        Task<User> Register(string email, string firstName,string lastName, string username, string password);
        Task<User> GetUser();

        Task<IEnumerable<Agenda>> GetAllAgendas();

        Task<IEnumerable<Sponsor>> GetAllSponsors();

        Task<IEnumerable<Workshop>> GetAllWorkshops();

        Task<QrCodeResponse> RedeemQrCode(string qrCode);

        Task<bool> SelectWorkshop(string workshopCode);

        //TODO: REGISTER QRCODE AND LEADERBOARD
    }
}