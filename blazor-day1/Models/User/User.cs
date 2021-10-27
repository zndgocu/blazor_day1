using System;

namespace Models.User
{
    public class User
    {
        private string _id;
        private string _pw;

        public User()
        {
        }

        public User(string id, string pw)
        {
            this._id = id;
            this._pw = pw;
        }

        public string Id { get => _id; set => _id = value; }
        public string Pw { get => _pw; set => _pw = value; }
    }
}
