using NET2U4_3_DAL;

namespace NET2U4_2_BLL
{
    public class ClassBll
    {
        public string LlamarHola(string nombre)
        {
            var dal = new ClassDal();
            return dal.Hola(nombre);
        }
    }
}
