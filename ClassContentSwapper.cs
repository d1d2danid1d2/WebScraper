using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScraper.Forms;

namespace WebScraper
{
    public interface IClassContentSwapper
    {
        Form ReturnSearchForm();
    }
    public class ClassContentSwapper : IClassContentSwapper
    {
        private readonly SearchForm searchForm;

        public ClassContentSwapper(SearchForm searchForm)
        {
            this.searchForm = searchForm;
        }
        public Form ReturnSearchForm()
        {
            return searchForm;
        }
    }
}
