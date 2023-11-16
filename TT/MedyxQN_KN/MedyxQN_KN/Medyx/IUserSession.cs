
namespace DEMO_SDK
{
    interface IUserSession : ISession
    {
        //List<Cert> listCertificates();
       
        //Cert getCertificate(String certUUID);

        bool sendUserOTP();

    }
}
