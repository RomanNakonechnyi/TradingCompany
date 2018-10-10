﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompanyDAL;
using Task1;

namespace Task1.BL
{
    public class ProviderBL
    {
        public ProviderDAL provider = new ProviderDAL();

        public void Manage()
        {
            Console.Clear();
            Console.WriteLine("List of suppliers - 1; \tNew supplier - 2; \tBlocked suppliers - 3;");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    GetSuppliers();
                    break;
                case 2:
                    AddNewSupplier();
                    break;
                case 3:
                    GetBlockedSuppliers();
                    break;
                default:
                    break;
            }
        }

        public void GetBlockedSuppliers()
        {
            ShowProviders(provider.GetBlockedProviders());
            Console.WriteLine("Unblock supplier - 1; \t Back - 0;");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    Unblock();
                    break;
                case 0:
                    Manage();
                    break;
                default:
                    break;
            }
        }

        public void Unblock()
        {
            Console.Write("Enter Provider Id :");
            Int32.TryParse(Console.ReadLine(), out int id);
            provider.UnblockById(id);
            GetBlockedSuppliers();
        }

        public void AddNewSupplier()
        {
            throw new NotImplementedException();
        }

        public void GetSuppliers()
        {
            var providers = provider.GetProviders();

            ShowProviders(provider.GetProviders());


            Console.WriteLine("Search - 1; \t Sort  - 2; \t Block provider - 3; \t Go Back - 0; ");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    SearchSuppliers();
                    break;
                case 2:
                    SortSuppliers();
                    break;
                case 3:
                    BlockProvider();
                    break;
                case 0:
                    Manage();
                    break;
                default:
                    break;
            }
        }

        public void BlockProvider()
        {
            Console.Write("Enter Provider Id :");
            Int32.TryParse(Console.ReadLine(), out int id);
            provider.BlockById(id);
            GetSuppliers();
        }

        private static void ShowProviders(List<tblProvider> list)
        {
            Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                "ID",
                "Name",
                "IsOrganiz",
                "Rating");
            foreach (var p in list)
            {
                Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                    p.providerID,
                    p.name,
                    p.isOrganization,
                    p.rating);
            }
        }
        private static void ShowProvider(tblProvider provider)
        {
        Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                "ID",
                "Name",
                "IsOrganiz",
                "Rating");
           
        Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                provider.providerID,
                provider.name,
                provider.isOrganization,
                provider.rating);
        }

        public void SearchSuppliers()
        {
            bool cont = true;
            Console.WriteLine("Choose way of searching :\n by name  - 1;\tby id - 2;");
            do
            {
                Console.Write("\nmake you choice : ");
                Int32.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        Console.Write("Enter name of supplier: ");
                        var supName = Console.ReadLine();
                        ShowProvider(provider.GetProviderByName(supName));
                        break;
                    case 2:
                        Console.Write("Enter name of supplier: ");
                        Int32.TryParse(Console.ReadLine(),out int id);
                        ShowProvider(provider.GetProviderById(id));
                        break;
                    default:
                        cont = false;
                        break;
                }
            } while (cont);
            GetSuppliers();
        }

        public void SortSuppliers()
        {
            bool cont = true;
            Console.WriteLine("Choose way of sorting :\n by name ascending - 1;" +
                " by name descending - 2; \n by rating ascending - 3; by rating descending - 4; ");
            do
            {
                Console.Write("make you choice : ");
                Int32.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        ShowProviders(provider.SortProviders(provider.GetProviders(), 1));
                        break;
                    case 2:
                        ShowProviders(provider.SortProviders(provider.GetProviders(), 2));
                        break;
                    case 3:
                        ShowProviders(provider.SortProviders(provider.GetProviders(), 3));
                        break;
                    case 4:
                        ShowProviders(provider.SortProviders(provider.GetProviders(), 4));
                        break;
                    default:
                        cont = false;

                        break;
                }
            } while (cont);
            GetSuppliers();
        }
    }
}
