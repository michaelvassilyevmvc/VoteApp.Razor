using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VoteApp.Console.Attributes;
using VoteApp.Console.Data;
using VoteApp.Console.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;
using VoteApp.Console.Extensions;
using System.ComponentModel;

namespace VoteApp.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lst = new Dictionary<State,string>();

            foreach (var item in (Enum.GetValues(typeof(State)) as State[]))
            {
                lst.Add(item,item.GetAttribute<DescriptionAttribute>().Description);
            }

            var enm = State.Active.GetAttribute<DescriptionAttribute>().Description;
            //var attrs = type.GetCustomAttributes(typeof(DisplayAttribute),false) as DisplayAttribute[];
            //var name = attrs.FirstOrDefault()?.Name;

            var candidates = GetCandidates();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Database.EnsureCreated();

                //db.Politics.Add(new PoliticCadidate
                //{
                //    Description = "Землю крестьянам, фабрики рабочим",
                //    PartyName = "КПРФ",
                //    State = State.Active,
                //    PoliticDocInfo = "Бум"
                //});
                //db.SaveChanges();
            }
        }

        public static Dictionary<string, string> GetCandidates()
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();

            var tps = Assembly.GetExecutingAssembly().GetTypes().Where(x => x != typeof(CandidateBase) && typeof(CandidateBase).IsAssignableFrom(x));
            if(tps == null)
            {
                 return _dict;
            }

            foreach (TypeInfo typeInfo in tps)
            {
                object[] attrs = typeInfo.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    CustomNameAttribute customAttr = attr as CustomNameAttribute;
                    if (customAttr != null)
                    {
                        string propName = typeInfo.Name;
                        string auth = customAttr.Name;

                        _dict.Add(propName, auth);
                    }
                }
            }

            return _dict;
        }
    }
}
