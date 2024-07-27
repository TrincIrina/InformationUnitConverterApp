namespace InformationUnitConverterApp.Converter
{
    public class InformationUnitConverter
    {
        public static double Convert(string initialVal, string convertedVal, double initialInf)
        {
            double convertedInf = 0;
            if (initialVal == "бит" || initialVal == "bit")
            {
                if (convertedVal == "байт" || convertedVal == "bytes")
                {
                    convertedInf = initialInf / 8;
                }
                if (convertedVal == "килобайт" || convertedVal == "kilobytes")
                {
                    convertedInf = initialInf / 8000;
                }
                if (convertedVal == "мегабайт" || convertedVal == "megabytes")
                {
                    convertedInf = initialInf / 8_000_000;
                }
                if (convertedVal == "гигабайт" || convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 8_000_000_000;
                }
                if (convertedVal == "тарабайт" || convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 8_000_000_000_000;
                }
            }
            if (initialVal == "байт" || initialVal == "bytes")
            {
                if (convertedVal == "бит" || convertedVal == "bit")
                {
                    convertedInf = initialInf * 8;
                }
                if (convertedVal == "килобайт" || convertedVal == "kilobytes")
                {
                    convertedInf = initialInf / 1000;
                }
                if (convertedVal == "мегабайт" || convertedVal == "megabytes")
                {
                    convertedInf = initialInf / 1_000_000;
                }
                if (convertedVal == "гигабайт" || convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 1_000_000_000;
                }
                if (convertedVal == "тарабайт" || convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1_000_000_000_000;
                }
            }
            if (initialVal == "килобайт" || initialVal == "kilobytes")
            {
                if (convertedVal == "бит" || convertedVal == "bit")
                {
                    convertedInf = initialInf * 8000;
                }
                if (convertedVal == "байт" || convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1000;
                }
                if (convertedVal == "мегабайт" || convertedVal == "megabytes")
                {
                    convertedInf = initialInf / 1000;
                }
                if (convertedVal == "гигабайт" || convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 1_000_000;
                }
                if (convertedVal == "тарабайт" || convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1_000_000_000;
                }
            }
            if (initialVal == "мегабайт" || initialVal == "megabytes")
            {
                if (convertedVal == "бит" || convertedVal == "bit")
                {
                    convertedInf = initialInf * 8_000_000;
                }
                if (convertedVal == "байт" || convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1_000_000;
                }
                if (convertedVal == "килобайт" || convertedVal == "kilobytes")
                {
                    convertedInf = initialInf * 1000;
                }
                if (convertedVal == "гигабайт" || convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 1000;
                }
                if (convertedVal == "тарабайт" || convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1_000_000;
                }
            }
            if (initialVal == "гигабайт" || initialVal == "gigabytes")
            {
                if (convertedVal == "бит" || convertedVal == "bit")
                {
                    convertedInf = initialInf * 8_000_000_000;
                }
                if (convertedVal == "байт" || convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1_000_000_000;
                }
                if (convertedVal == "килобайт" || convertedVal == "kilobytes")
                {
                    convertedInf = initialInf * 1_000_000;
                }
                if (convertedVal == "мегабайт" || convertedVal == "megabytes")
                {
                    convertedInf = initialInf * 1000;
                }
                if (convertedVal == "тарабайт" || convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1000;
                }
            }
            if (initialVal == "тарабайт" || initialVal == "tarabytes")
            {
                if (convertedVal == "бит" || convertedVal == "bit")
                {
                    convertedInf = initialInf * 8_000_000_000_000;
                }
                if (convertedVal == "байт" || convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1_000_000_000_000;
                }
                if (convertedVal == "килобайт" || convertedVal == "kilobytes")
                {
                    convertedInf = initialInf * 1_000_000_0000;
                }
                if (convertedVal == "мегабайт" || convertedVal == "megabytes")
                {
                    convertedInf = initialInf * 1_000_000;
                }
                if (convertedVal == "гигабайт" || convertedVal == "gigabytes")
                {
                    convertedInf = initialInf * 1000;
                }
            }
            return convertedInf;
        }
    }
}
