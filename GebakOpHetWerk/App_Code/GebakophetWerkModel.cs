﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Order
{
    public Order()
    {
        this.OrderPies = new HashSet<OrderPie>();
    }

    public int ID { get; set; }
    public int UserID { get; set; }
    public Nullable<System.DateTime> OrderDate { get; set; }
    public Nullable<decimal> Totaalprijs { get; set; }

    public virtual User User { get; set; }
    public virtual ICollection<OrderPie> OrderPies { get; set; }
}

public partial class OrderPie
{
    public int OrderID { get; set; }
    public int PieID { get; set; }
    public int Number { get; set; }
    public decimal AmountPrice { get; set; }

    public virtual Order Order { get; set; }
    public virtual Pie Pie { get; set; }
}

public partial class Pie
{
    public Pie()
    {
        this.OrderPies = new HashSet<OrderPie>();
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }
    public decimal Price { get; set; }
    public bool Activated { get; set; }

    public virtual ICollection<OrderPie> OrderPies { get; set; }
}

public partial class User
{
    public User()
    {
        this.Orders = new HashSet<Order>();
    }

    public int ID { get; set; }
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Rights { get; set; }
    public bool Activated { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}

public partial class AlleBestellingen_Result
{
    public string Klantnaam { get; set; }
    public string Taartnaam { get; set; }
    public decimal prijs { get; set; }
    public int aantal { get; set; }
    public System.DateTime besteldatum { get; set; }
}

public partial class AlleKlanten_Result
{
    public string Klantnaam { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }
    public string Stad { get; set; }
    public string postcode { get; set; }
    public string gebruikersnaam { get; set; }
    public string Column1 { get; set; }
    public bool Rechten { get; set; }
    public bool Actief { get; set; }
}

public partial class Tebakkentaarten_Result
{
    public string taartnaam { get; set; }
    public Nullable<int> Nummer { get; set; }
}
