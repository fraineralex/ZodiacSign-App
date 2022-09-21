using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModel;
using Application.Enum;
using Application.Repository;

namespace Application.Services
{
    public class ZodiacSignService
    {
        public void Add(ZodiacSignCreateViewModel vm)
        {
            int month = vm.Month;
            int day = vm.Day;

            switch (month)
            {
                case (int)Months.December:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 22 ? "Sagitario" : "Capricornio" });
                        break;
                    }

                case (int)Months.November:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 22 ? "Escorpio" : "Sagitario" });
                        break;
                    }

                case (int)Months.October:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 23 ? "Libra" : "Escorpio" });
                        break;
                    }

                case (int)Months.September:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 23 ? "Virgo" : "Libra" });
                        break;
                    }

                case (int)Months.August:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 23 ? "Leo" : "Virgo" });
                        break;
                    }

                case (int)Months.July:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 23 ? "Cancer" : "Leo" });
                        break;
                    }

                case (int)Months.June:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 23 ? "Geminis" : "Cancer" });
                        break;
                    }

                case (int)Months.May:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 21 ? "Tauro" : "Geminis" });
                        break;
                    }

                case (int)Months.April:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 20 ? "Aries" : "Tauro" });
                        break;
                    }

                case (int)Months.March:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 21 ? "Piscis" : "Aries" });
                        break;
                    }

                case (int)Months.February:
                    {
                        if(day < 29)
                        {
                            ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 20 ? "Acuario" : "Piscis" });
                            break;
                        }
                        else
                        {
                            ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = "Error, date fake" });
                            break;
                        }
                    }

                case (int)Months.January:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = day < 21 ? "Capricornio" : "Acuario" });
                        break;
                    }

                    default:
                    {
                        ZodiacSignRepository.Instance.zodiacSignInstance.ZodiacSign.Add(new ZodiacSignViewModel { Sign = "Error, date fake" });
                        break;
                    }
            }
        }

        public ZodiacSignListViewModel GetAll()
        {
            return ZodiacSignRepository.Instance.zodiacSignInstance;
        }

    }
}
