using System.Collections.Generic;
using Lab12.DAL;
using Lab12.DTO;

namespace Lab12.BUS
{
    public class KhoaBUS
    {
        private readonly KhoaDAL _dal = new KhoaDAL();

        public List<KhoaDTO> GetAll()
        {
            return _dal.GetAll();
        }
    }
}
