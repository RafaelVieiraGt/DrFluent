using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;


namespace DrFluentBeta
{
    internal static class FireStoreHelper

    {
        static string fireconfig = @"
        
{
  ""type"": ""service_account"",
  ""project_id"": ""drfluentbeta"",
  ""private_key_id"": ""06526bbc82761f9a6be74580c21b67013771bbb9"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQC/0AwskXdcfBKp\nXSCXjU726+qWMjxj0Zf0jEE0alZ2sU79cofP3xPJYw8PVGwVSay0FwtZgdoGowFy\nxwltZfJES3tuaN+XQ+9ZMSb7p+K6MaJRsxVwrbhq3C/EtxlaoTTLk5GT6b5VE9jw\n1vjAE2ISKmNuPttALQbiF5MgLvYgDKcPSMpWfjnjjJenA66/lJJttwFByuXNbGWs\ntiu16Xc0revrKunR212S2hpos4wSwMbP+FdiNI3XP3aW0jU736Ptax1iAeWoO2Le\nS1DRGI34qkVSEipuD14Dw+tLKAl0VapeyPr2cbFKMXyEv4gNYStdre5bk7BjLs5q\ntx5MlwKFAgMBAAECggEATWGaN7SrqaToRmkqh9lbHORJ7DPyBvb8TYzzlTi9Dv8y\n9a5pueOt8NXEspOFUwU45iJR0tc+5OSH5g0D8Z1qIkEtV3p5kWW3vozExEuTfTge\n2sTbhmye9IVFxB913Aki6mnrFff7cAkkwOyIx7xKGTf+ivBStU4086s9EIPBiWW9\n5JghK5bQ9UrcQiyV1i9rb5ab4HUOpnFUH4lH5z5+5uEm9BuBLq23Fi5EXmIvMA/f\nlZaJg7d3OqF73kUdF88MaTxtRDXk7ACAaND9w1FEKXOJ9I4Fzd5nCBRhg6hPNLa8\nzwiEjMobMbWrnIBoW55gqsw9t5Atjen6ojhBLXyJVQKBgQDxJq8gc6KxSegU2ypw\nUGSyjViY+VVVbFNJRP2nJ9bvoKiJn+Z92iAjHqRBM/PZY9iyvUbSJDNa7PImvgv/\nu7JosTyFP8xo/2JLS7CnzoSXvuHQGJ5BhdmEqiEFuCYUHnlQhB9HjwVi64F/t+m5\ncHUU3GcvRA4oLna1Ttt+/qfSOwKBgQDLn6GncugdonwSHmePQfxgRze1/teyXss3\n1mPFViulIEYftqc9f7JDs6+8/AW8ona3mV5Tdg7Ntgmp+bSGYXi5mc4magsG9UTq\nDSdc8yJDaLLNtCbXjA70aJUVYwqbNXuCdK6QxptkodGVT2Vkh4koR9lvEQkFgifq\n+op6SkRyPwKBgQDENzK12AEf+j/RgIbmfjOBKQtW5UFu0UZvTqiJcxwrPHEGEkpM\nSshtawhBWZFnaBuxS9stL3Ft4XAi3+4JdmLzVosk7MVZBbuoAn1J/PrcMd+xH+bc\n75kOnhNigPTS1/zj6607336Ff5SOJEoTrhJGGBQJXHmcbjn+ypxEl9ZbcwKBgEmW\n3nBK2dJj950AugKPIWuWMW8ns8J1+dGrPJGD6/AYct9hPp2+Oam4Fcoh9tzOhkMi\nPXHCV+VGZcW1ReXO8jd5e4RsjKGuIILJ0DEKeZaNDxnCgsshhgIUjdSV365qLMHf\n83rFHEHJLZpdgFJNnWceWFmIeY8xE8YbV9KMZqI3AoGAGsyt1L3GhKCfIZ2SEoJD\nO9MxBWgWOuMfZcE/7fn1JKAmK/UcXGvxX4GGDbd9dRAgjZ2Xe8DpjmWHaw9mQ4e/\nvWMVi5ohkfUGz8qi8wWKRJxLc5iu+T+oa019BL60aODST/aCTD2kSxhx8uAWgrKC\ns6bWsdnyVqTkJNOX7vCltyE=\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-d3tep@drfluentbeta.iam.gserviceaccount.com"",
  ""client_id"": ""114351277850620835027"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-d3tep%40drfluentbeta.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
}";



/*{
          ""type"": ""service_account"",
          ""project_id"": ""drfluentbeta-f3461"",
          ""private_key_id"": ""77af98caa2b397ad7621cc596e07482acbd3a30d"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQC9l7CCU+RcE3KU\nVDFp+cJf7zTP4bbxB8PlW8Kn/X0KHVceIcRadBzF0X8eNUf/tOn73OSKeVoEbyzS\nyujkJOQlaacb1XQU5nA4Dg2Dttol4z1FMLuLbrT2ZLE6NWiTuY6/pqlnbHVJwllR\n7JJWS1uDjGsuB0wbwhVnqCfaMtRWVR1nDXd0fhZgmoAMLxPUNnfBrp4hnaUheyIq\n7P2a6ne4CU7CDb4NZdx2BJ3bAA/Rkn+V7SZMeJqqkR3bQzlBw4i4i6j/mVZHygW6\nGUpUTgIFSkgipICsq2ncXoXA1UsvnNY0gB495zmC9Uvd67qYCiNh044CXBryD+gW\ncVtG70V7AgMBAAECggEAVnUcGvKiypJbx+R0/DzXNORikwH9aQD/hlJH/E+Oe9RR\na/4+Cnm0vUkBzQbDJIqdwStEVRltwWPpbt71QUTJfX4mpHy8iONk/Ur7QrtZ07lC\nsZC9laIQh+P3JfJBFEykGiWoTu+YtOAZ11Aok42d1+lq3vyY6nehRznZoplXV16C\ngvywly9kFV0G3hKhz42qTp8F0n+rRRxLVJu98abrQtqVLVvdwsfYNC6Px5hcF543\nnXunZYuthYPg1aQI1Q15xPEPJ/3y3tY/dkhXeIj8YqDzB94l1vCT3mn/NA/9QHDo\nu4il4eqvpSESWVW1fyBth0ACxMdm7NrepZwbAnRB0QKBgQD6tu/XlML3bmuBJ8Z2\ns6E+UpD2bZmIn3JuXQL3l5XgW0yNOkhbPjr6eBP8nMEGUc/2PmfhGL8IfZnVOCT9\nLb0aHApFqapQT4G0oy40rsufdJsQvqn/3eo0+gdyfykOJ3YksJB+pvsa+5QapWUn\nLrb+7tP4nVsLRCa9fyrsa2iTFQKBgQDBluMxERZ047/GNf6RsuSHS6RF0P2AH1vW\ny/x4PFZqohaLFgqbGUQKeV4nUKUCEGaYzBvIUX2eKFzWfgmann+h3bOrPu7yiSOe\nMe/Qpj34UTeJaRLd9fuedW9Ev+x4pY5zUsGLP9HPATbzJiAsEMESQg6Oe9J7hYhx\n1nwixULaTwKBgQDjBt6+d33o8rs0lCD6AgUj2z5bd7mM5t2HJIB4VXKpW+NBC6LT\nxNFBV5S5rfR4VYMcdzw3r+HkvV+cnR+Zh15ykyuWE2IfIS/Rs+Y2XIYUmVGFYzGr\neXcIi9RMkOtLXt5zsNLXbTt7Ho7pZhXn2jxpMzkNKuhzlj4CYHIs7cIfVQKBgBoW\nu4dhRiV6i92qaSQ5d5LEHt9Jyt/5WecYlm2dtAeq0F7uGX/NZ94BfS7PL22XyDvP\nRe85DDTEO76sPZ8YvRqTRiNN1+XXlXU8RZVY0gEk8NcT0fcXr1ErglNBihy4MvpX\nrL2XXC8Jet5JxQwrNdnADTYmebcrx7ePsCr/aoMBAoGAY+oEC3zBKfMOnZTCH/z6\neqYZyMpKR/rGRoUBIjx1VYqNDbi6yS5V/SwCqwUIMF8GhaEoYC89Ar9dGSSFJf3V\nK+ss/VzJQpSY2FvCZ7rEWOesxWeMYmKSJMPGPlIWhkHtlfDXQ9QwxQ7rNguYIpyf\n9lR+tMkLFcGG+q6izuJy3iU=\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-c0kqt@drfluentbeta-f3461.iam.gserviceaccount.com"",
          ""client_id"": ""112076972758328017739"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-c0kqt%40drfluentbeta-f3461.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }   ";*/

        static string filepath = "";
        public static FirestoreDb Database  { get; private set ;}


        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("drfluentbeta");



        }
    }  


}
