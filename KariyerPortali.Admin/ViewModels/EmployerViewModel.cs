﻿using KariyerPortali.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KariyerPortali.Admin.ViewModels
{
    public class EmployerViewModel
    {
        public int EmployerId { get; set; }
        public string Logo { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "İşveren adı gereklidir.")]
        [DisplayName("İşveren Adı")]
        public string EmployerName { get; set; }

        [DisplayName("Sektör")]
        public int SectorId { get; set; }
        public Sector Sector { get; set; }

        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Şehir")]
        public int CityId { get; set; }
        public City City { get; set; }

        [DisplayName("Telefon")]

        public string Phone { get; set; }

        [DisplayName("E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Web Site")]
        public string WebSite { get; set; }

    }
}