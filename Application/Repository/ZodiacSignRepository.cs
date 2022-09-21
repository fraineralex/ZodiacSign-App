using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public sealed class ZodiacSignRepository
    {
        private ZodiacSignRepository()
        {

        }

        public static ZodiacSignRepository Instance { get; } = new();
        public ZodiacSignListViewModel zodiacSignInstance = new();
    }
}
