using October26.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection.List
{
         record StudentResultWrapper(bool IsFailed,Student student = null);
}
