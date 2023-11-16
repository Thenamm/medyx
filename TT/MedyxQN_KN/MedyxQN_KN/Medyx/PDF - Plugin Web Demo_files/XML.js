// Phần mềm BkavCA Signer Plugin mở rộng tính năng cho trình duyệt: Chrome, Firefox, IE, ... gọi tắt là plugin
/*
 Copyright 2018 BkavCoreCA By VietPDb

 */

var dllName = "bkavcaetoken,bkavcsp,BkavCA,beidcsp,BkavCAv2S,bkavcaetoken_p11,viettel-ca_v2,viettel-ca_v3,viettel-ca_v4,viettel-ca_v5,beidpkcs11D,nca_v4,nca_v4_csp,viettel-ca,vnptca_p11_v6,vnptca_p11_v6_s,vnptca_p11_v7,vnptca_p11_v8,vnptca_p11_v9,vnptca_p11_v10,vnpt-ca_csp11,vnpt-ca_v34,vnpt-ca_cl_v1,wdsafe3,CA2_v34,CA2_csp11,ca2_ace_csp11,CA2CSP11_v2,wdsafe3,st3csp11,viettel-ca_v1,viettel-ca_v2,viettel-ca_v3,viettel-ca_v4,viettel-ca_v5,viettel-ca_v6,viettel-ca_s,viettel-ca_v2_csp,viettel-ca_v2_csp.EN,viettel-ca_v2_csp.VN,viettel-ca_v2_s,fptca_v3,fptca_v3_s,fpt-ca,fpt-ca-stx,fpt_ca,CKCA,safe-ca,safe-ca_v2,Vina-CA,Vina-CAv3,Vina-CA_s,Vina-CAv4,Vina-CAv5,NEWTEL-CA,vdctdcsp11,ShuttleCsp11_3003,ngp11v211,st3csp11,gclib,psapkcs,ostc1_csp11,etpkcs11,U1000AUTO,eToken,ostt1_csp11,ostt2_csp11,ostt3_csp11,ostc2_csp11,nca_eps2k2a,nca_eps2k3a";

function SignXML(xmlPathIn, serialNumber, jsCallback) {

    var objXml = new ObjXmlSigner();                       // Object xml 
    if (serialNumber == "") {
        alert("Nhập serial number");
        return;
    }
    if (xmlPathIn == "" || undefined == xmlPathIn) {
        alert("Bạn chưa nhập XML");
        return;
    }
  
    objXml.Base64String = xmlPathIn; 
    objXml.CertificateSerialNumber = serialNumber;      //1         // serial
    objXml.SigningType = OOXML_SIGNING_TYPE.SIGN_OOXML_BASE64;   // chọn kiểu ký: ký file, ký xml base64, ký xml xpath base64
    objXml.FunctionCallback = jsCallback;  //  Kết quả ký sẽ được plugin tự động trả về paramater của hàm này 
    objXml.SigningTime = "2015/04/08 22:50:11";          //1  // ngày ký (phải đúng format yyyy/mm/dd h:m:s)
    try {

        BkavCAPlugin.SetLicenseKey(licenseKey);       
       BkavCAPlugin.SetUsePKCS11(SET_USE_PKCS11.YES);
      
        BkavCAPlugin.SetDLLName(dllName);
        BkavCAPlugin.SetHashAlgorithm(HASH_ALGORITHM.SHA1);
        BkavCAPlugin.SetPINCache(0,0,0);
       
        BkavCAPlugin.SignXML(objXml);
       
    } catch (e) {
        alert(e);
    }
}
// VerifyXML
function VerifyXML(xmlFile, jsCallback) {
    var timeCheck = "2015/09/17 14:11:11"; //2016/08/01 17:18:32
    timeCheck = getDateTime();
    var iRet;   
    if (xmlFile == "" || undefined == xmlFile) {
        alert("Bạn chưa nhập nội dung cần xác thực");
        return;
    }
    if (timeCheck == "" || undefined == timeCheck) {
        alert("Bạn chưa nhập thời gian");
        return;
    }
    try {
        var objVerifyXML = new ObjVerifier();
        objVerifyXML.PathFileInput = xmlFile;
        objVerifyXML.TimeCheck = timeCheck;
        objVerifyXML.VerifyType = VERIFY_TYPE.VERYFY_FILE;
        objVerifyXML.FunctionCallback = jsCallback;  //  Kết quả ký sẽ được plugin tự động trả về paramater của hàm này 
        BkavCAPlugin.SetLicenseKey(licenseKey);
        BkavCAPlugin.SetHashAlgorithm(HASH_ALGORITHM.SHA256);
        BkavCAPlugin.VerifyXML(objVerifyXML);
        
    } catch (e) {
        alert(e);
    }
}

