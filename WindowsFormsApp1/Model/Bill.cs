using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Bill
    {
        private int id;
        private DateTime dCreatedTime;
        private int serveNumber;
        private int idUser;
        private int idOrder;

        public Bill()
        {
        }

        public Bill(int id, DateTime dCreatedTime, int serveNumber, int idUser, int idOrder)
        {
            this.id = id;
            this.dCreatedTime = dCreatedTime;
            this.serveNumber = serveNumber;
            this.idUser = idUser;
            this.idOrder = idOrder;
        }

        public int Id { get => this.id; set => this.id = value; }

        public DateTime DCreatedTime { get => this.dCreatedTime; set => this.dCreatedTime = value; }

        public int ServeNumber { get => this.serveNumber; set => this.serveNumber = value; }

        public int IdUser { get => this.idUser; set => this.idUser = value; }

        public int IdOrder { get => this.idOrder; set => this.idOrder = value; }
    }
}
