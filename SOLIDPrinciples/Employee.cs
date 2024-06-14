using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class Employee
    {

        public void save(Employee emp)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Logger logger=new Logger();
                logger.logerror(ex.Message);
            }
        }
    }
}
