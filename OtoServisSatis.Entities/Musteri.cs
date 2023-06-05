﻿using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Musteri : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Arac")]
        public int AracId { get; set; }
        [StringLength(50)]
        [Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50)]
        [Display(Name = "Soyadı"), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Soyadi { get; set; }
        [StringLength(11)]
        [Display(Name = "TC numarası")]
        public string? TcNo { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(500), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string? Adres { get; set; }
        [StringLength(15)]
        public string? Telefon { get; set; }
        public string? Notlar { get; set; }
        [Display(Name = "Arac")]
        public virtual Arac? Arac { get; set; }
    }
}
