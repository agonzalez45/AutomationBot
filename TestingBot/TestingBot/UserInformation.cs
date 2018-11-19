using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using LiteDB;
namespace TestingBot
{
    class UserInformation
    {
        public class UserInfo
        {

            public int ID { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public string State { get; set; }
            public string CCNumber { get; set; }
            public string CVV { get; set; }
            public string CCMonth { get; set; }
            public string CCYear { get; set; }
            public string ProfileName { get; set; }

            public string DBInsert()
            {
                using (var db = new LiteDatabase(@"MyData.db"))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<UserInfo>("users");
                    var UserInformation = new UserInfo
                    {
                        FullName = this.FullName,
                        Email = this.Email,
                        Phone = this.Phone,
                        Address = this.Address,
                        City = this.City,
                        Zip = this.Zip,
                        State = this.State,
                        CCNumber = this.CCNumber,
                        CVV = this.CVV,
                        CCMonth = this.CCMonth,
                        CCYear = this.CCYear,
                        ProfileName = this.ProfileName
                    };

                    col.Insert(UserInformation);
                }
                return "Success";
            }
            public List<UserInformation.UserInfo> DBResults()
            {
                List<UserInformation.UserInfo> AllProfiles = new List<UserInformation.UserInfo>();

                using (var db = new LiteDatabase(@"MyData.db"))
                {
                    var col = db.GetCollection<UserInfo>("users");
                    var results = col.Find(Query.All(Query.Descending));
                    List<UserInformation.UserInfo> Res = results.ToList();
                    for(int i = 0; i < results.Count(); i++)
                    {
                        AllProfiles.Add(Res[i]);
                    }
                }
                
                return AllProfiles;
            }

        }
        


    }
}
