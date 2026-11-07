using System.Collections.Generic;
using Lab12.DAL;
using Lab12.DTO;

namespace Lab12.BUS
{
    public class HocPhanBUS
    {
        private readonly HocPhanDAL _dal = new HocPhanDAL();

        public List<HocPhanDTO> GetAll()
        {
            return _dal.GetAll();
        }
    }
}
