﻿using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
	public class CatalogContextSeed
	{
		public static void SeedData(IMongoCollection<Product> productCollection)
		{
			bool existProduct = productCollection.Find(p => true).Any();
			if (!existProduct)
			{
				productCollection.InsertManyAsync(GetPreconfiguredProducts());
			}
		}

		private static IEnumerable<Product> GetPreconfiguredProducts()
		{
			return new List<Product>()
			{
				new Product()
                {
                  Name = "sunt consequat id do est",
                  Summary = "sunt ea pariatur aliquip irure quis veniam consequat dolore amet adipisicing aute magna reprehenderit",
                  Description = "ullamco labore minim reprehenderit cupidatat id non consequat ut ad do commodo ad enim",
                  ImageFile = "Product-0.png",
                  Price = 898,
                  Category = "id"
				        }, 
                new Product()
                {
                  Name = "eiusmod cillum proident proident laborum",
                  Summary = "consequat minim enim qui elit esse laboris cillum eiusmod in reprehenderit exercitation laborum incididunt",
                  Description = "quis non sint non proident anim sint aute reprehenderit aliqua sit dolore non sunt",
                  ImageFile = "Product-1.png",
                  Price = 291,
                  Category = "commodo"
                }, 
                new Product()
                {
                  Name = "eiusmod ipsum cupidatat elit ad",
                  Summary = "labore consectetur occaecat magna pariatur eu duis ad eiusmod sit irure consequat velit Lorem",
                  Description = "voluptate mollit consequat aute mollit anim sit adipisicing mollit aute id esse laboris dolor",
                  ImageFile = "Product-2.png",
                  Price = 1470,
                  Category = "sunt"
                }, 
                new Product()
                {
                  Name = "cupidatat laborum non elit ipsum",
                  Summary = "excepteur ea nisi exercitation dolore est excepteur mollit nulla aliqua anim laboris in eu",
                  Description = "aute mollit amet laboris occaecat laboris consectetur irure aliqua amet adipisicing sint non ut",
                  ImageFile = "Product-3.png",
                  Price = 422,
                  Category = "id"
                }, 
                new Product()
                {
                  Name = "aute ipsum non officia officia",
                  Summary = "eiusmod enim aliqua dolor irure sunt occaecat excepteur nisi adipisicing consectetur enim voluptate pariatur",
                  Description = "pariatur aliquip elit quis dolor deserunt id consectetur irure Lorem eu consectetur consectetur ad",
                  ImageFile = "Product-4.png",
                  Price = 981,
                  Category = "dolor"
                }, 
                new Product()
                {
                  Name = "eiusmod aute officia consectetur consequat",
                  Summary = "commodo quis mollit irure aliquip aliqua nisi amet dolor eiusmod quis veniam magna labore",
                  Description = "sint excepteur reprehenderit anim mollit aliqua est officia sunt consectetur consectetur laborum laboris esse",
                  ImageFile = "Product-5.png",
                  Price = 1714,
                  Category = "ex"
                }, 
                new Product()
                {
                  Name = "laboris sit nulla sunt excepteur",
                  Summary = "et consequat commodo minim aliquip labore commodo ipsum laborum eiusmod consequat cillum id esse",
                  Description = "velit consectetur commodo consectetur laborum officia elit proident eu deserunt commodo occaecat occaecat non",
                  ImageFile = "Product-6.png",
                  Price = 971,
                  Category = "labore"
                }, 
                new Product()
                {
                  Name = "consequat aliquip aliqua nulla incididunt",
                  Summary = "dolore in anim magna quis aliquip irure quis minim do deserunt cillum ipsum do",
                  Description = "ea consectetur proident ea eu velit aliquip do cillum sit quis qui dolor ea",
                  ImageFile = "Product-7.png",
                  Price = 1707,
                  Category = "est"
                }, 
                new Product()
                {
                  Name = "proident mollit consequat voluptate culpa",
                  Summary = "nulla aliquip laboris reprehenderit minim proident nisi ad incididunt aute amet tempor adipisicing esse",
                  Description = "est sint ad aute velit aute sit aliquip pariatur eu deserunt aliqua anim minim",
                  ImageFile = "Product-8.png",
                  Price = 700,
                  Category = "officia"
                }, 
                new Product()
                {
                  Name = "anim magna tempor reprehenderit reprehenderit",
                  Summary = "aliquip laboris sint nulla laboris minim irure occaecat quis pariatur dolor ullamco et dolore",
                  Description = "Lorem commodo eiusmod aliqua anim in quis sit aute Lorem sit id aliqua amet",
                  ImageFile = "Product-9.png",
                  Price = 270,
                  Category = "reprehenderit"
                }, 
                new Product()
                {
                  Name = "excepteur excepteur incididunt minim laborum",
                  Summary = "quis sit minim nisi eiusmod ad deserunt occaecat minim ad ad tempor pariatur tempor",
                  Description = "incididunt fugiat quis id nisi reprehenderit officia cillum nisi excepteur excepteur officia aliqua elit",
                  ImageFile = "Product-10.png",
                  Price = 911,
                  Category = "eiusmod"
                }, 
                new Product()
                {
                  Name = "dolore sunt incididunt laborum magna",
                  Summary = "irure non eu amet incididunt labore elit esse consequat ipsum incididunt amet excepteur ipsum",
                  Description = "nulla ullamco dolore consequat nisi nulla elit incididunt officia in non adipisicing velit enim",
                  ImageFile = "Product-11.png",
                  Price = 1320,
                  Category = "consectetur"
				        },
				        new Product()
                {
                  Name = "dolor et non ipsum sint",
                  Summary = "qui quis aute veniam eiusmod aliqua sunt deserunt in dolor ullamco mollit culpa est",
                  Description = "in voluptate labore anim deserunt esse aliqua sint consequat duis in labore excepteur aute",
                  ImageFile = "Product-12.png",
                  Price = 1090,
                  Category = "culpa"
                }, 
                new Product()
                {
                  Name = "culpa aliquip nostrud fugiat aute",
                  Summary = "exercitation qui occaecat non commodo ex eu ipsum sint dolor irure excepteur consequat sunt",
                  Description = "officia enim cupidatat laborum irure eiusmod minim veniam ea eiusmod proident eu deserunt pariatur",
                  ImageFile = "Product-13.png",
                  Price = 593,
                  Category = "eu"
                }, 
                new Product()
                {
                  Name = "magna voluptate cillum consectetur officia",
                  Summary = "quis id aute non ex occaecat sint exercitation quis nisi et in amet proident",
                  Description = "minim laboris Lorem in proident irure sunt ex ea in amet esse aliquip laboris",
                  ImageFile = "Product-14.png",
                  Price = 400,
                  Category = "enim"
                }, 
                new Product()
                {
                  Name = "deserunt exercitation irure minim sunt",
                  Summary = "commodo cupidatat enim tempor laboris magna anim pariatur deserunt id voluptate dolor excepteur consectetur",
                  Description = "Lorem pariatur nisi duis consectetur duis duis enim tempor nisi nisi fugiat excepteur esse",
                  ImageFile = "Product-15.png",
                  Price = 1315,
                  Category = "elit"
                }, 
                new Product()
                {
                  Name = "exercitation reprehenderit est id nisi",
                  Summary = "pariatur esse Lorem sunt officia sunt sit occaecat eiusmod irure veniam ad eu consequat",
                  Description = "veniam reprehenderit esse ut adipisicing et sunt do consectetur labore et laboris eu laboris",
                  ImageFile = "Product-16.png",
                  Price = 1174,
                  Category = "exercitation"
                }, 
                new Product()
                {
                  Name = "aliqua sunt sint cupidatat reprehenderit",
                  Summary = "consequat culpa nulla nulla dolore nostrud minim laborum velit voluptate consectetur Lorem labore commodo",
                  Description = "aute occaecat fugiat ad id quis ea id ullamco qui Lorem anim qui adipisicing",
                  ImageFile = "Product-17.png",
                  Price = 112,
                  Category = "officia"
                }, 
                new Product()
                {
                  Name = "magna ut proident fugiat fugiat",
                  Summary = "amet est eu nisi esse veniam nostrud Lorem nostrud commodo elit aute deserunt nulla",
                  Description = "cillum eu dolore ullamco ut duis reprehenderit sit do magna ipsum culpa laboris quis",
                  ImageFile = "Product-18.png",
                  Price = 1445,
                  Category = "laborum"
                }, 
                new Product()
                {
                  Name = "mollit aute qui fugiat eiusmod",
                  Summary = "esse minim enim adipisicing veniam anim ea ipsum dolor commodo culpa officia eu sunt",
                  Description = "magna dolor duis veniam qui nostrud veniam non non do do est ullamco labore",
                  ImageFile = "Product-19.png",
                  Price = 699,
                  Category = "et"
                }
            };
			
		}
	}
}
