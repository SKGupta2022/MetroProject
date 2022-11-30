using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace JaipurMetroAdmin.Commom
{
    public class SystemMessagesHelper
    {
        /// <summary>
        /// SystemMessages Class
        /// </summary>
        public enum SystemMessages
        {
            /// <summary>
            /// The success
            /// </summary>
            [Description("Success")]
            Success,

            /// <summary>
            /// The fail
            /// </summary>
            [Description("Fail")]
            Fail,

            /// <summary>
            /// Data not found
            /// </summary>
            [Description("Data not found.")]
            DataNotFound,

            /// <summary>
            /// The request null
            /// </summary>
            [Description("Invalid request.")]
            RequestNull,

            /// <summary>
            /// The login success
            /// </summary>
            [Description("Login successfully.")]
            LoginSuccess,

            /// <summary>
            /// The login failed
            /// </summary>
            [Description("Please Enter Valid Username and Password.")]
            LoginFailed,

            /// <summary>
            /// The login failed
            /// </summary>
            [Description("Please verify email that sent in your email.")]
            PleaseVerifyEmail,

            /// <summary>
            /// The blocked user
            /// </summary>
            [Description("Your access to cyberworld is blocked by administrator.")]
            BlockedUser,

            /// <summary>
            /// The DeActive user
            /// </summary>
            [Description("Your access to cyberworld is Deactivated by administrator.")]
            DeActiveUser,

            /// <summary>
            /// The Rejected user
            /// </summary>
            [Description("Your access to cyberworld is not approved by administrator.Please try after some time.")]
            RejectedUser,

            /// <summary>
            /// The logout success
            /// </summary>
            [Description("Log out successfully.")]
            LogoutSuccess,

            /// <summary>
            /// The logout failed
            /// </summary>
            [Description("Log out Failed!")]
            LogoutFailed,

            /// <summary>
            /// The reset password success
            /// </summary>
            [Description("Password reset successfully. Please login using the new login credentials.")]
            ResetPasswordSuccess,

            /// <summary>
            /// The reset password fail
            /// </summary>
            [Description("Please enter valid email and reset code.")]
            ResetPasswordFail,

            /// <summary>
            /// The change password success
            /// </summary>
            [Description("Password changed successfully. Please login using the new login credentials.")]
            ChangePasswordSuccess,

            /// <summary>
            /// The change password fail
            /// </summary>
            [Description("Password change failed.")]
            ChangePasswordFail,

            /// <summary>
            /// The reset password fail
            /// </summary>
            [Description("Please eneter valid old password.")]
            OldPasswordIncorrect,

            /// <summary>
            /// The no record found
            /// </summary>
            [Description("No record found!")]
            NoRecordFound,

            /// <summary>
            /// The error while process request
            /// </summary>
            [Description("Error while process request!")]
            ErrorWhileProcessRequest,

            /// <summary>
            /// Something went wrong
            /// </summary>
            [Description("Something went wrong, please try again!")]
            SomethingWentWrong,

            /// <summary>
            /// The Registration Success
            /// </summary>
            [Description("User registration successfully.")]
            RegistrationSuccess,

            /// <summary>
            /// The Registration Failed
            /// </summary>
            [Description("User registration failed.")]
            RegistrationFailed,

            /// <summary>
            /// The Duplicate Account Message
            /// </summary>
            [Description("Mobile Number already registered with cyberworld.")]
            DuplicateAccountMessage,

            /// <summary>
            /// The Duplicate Email Account Message
            /// </summary>
            [Description("Email already registered with cyberworld.")]
            DuplicateEmailAccountMessage,

            /// <summary>
            /// The  details found success
            /// </summary>
            [Description("User details found successfully.")]
            UserFoundSuccess,

            /// <summary>
            /// The  details found fail
            /// </summary>
            [Description("User details not found.")]
            UserFoundFail,

            /// <summary>
            /// The Profile Update Success
            /// </summary>
            [Description("Profile updated Successfully.")]
            ProfileUpdateSuccess,

            /// <summary>
            /// The Profile Update failed
            /// </summary>
            [Description("Profile update failed.")]
            ProfileUpdateFailed,

            /// <summary>
            /// OTP send successfully
            /// </summary>
            [Description("OTP sent successfully.")]
            OtpSendSuccess,

            /// <summary>
            /// OTP send failed
            /// </summary>
            [Description("OTP send failed.")]
            OtpSendFailed,

            /// <summary>
            /// OTP verified successfully
            /// </summary>
            [Description("OTP verify successfully.")]
            OtpVerifySuccess,

            /// <summary>
            /// OTP verified failed
            /// </summary>
            [Description("OTP verify failed.")]
            OtpVerifyFailed,

            /// <summary>
            /// Pin Generated successfully
            /// </summary>
            [Description("Pin Generated successfully.")]
            PinGenerateSuccess,

            /// <summary>
            /// OTP verified failed
            /// </summary>
            [Description("Pin Generate failed.")]
            PinGenerateFailed,

            /// <summary>
            /// Pin verified successfully
            /// </summary>
            [Description("Pin verified successfully.")]
            PinVerifySuccess,

            /// <summary>
            /// Pin verified failed
            /// </summary>
            [Description("Please enter valid pin.")]
            PinVerifyFail,

            /// <summary>
            /// Your password has been sent
            /// </summary>
            [Description("Your password recovery link sent to your requested mail id. Please check your mail for further details.")]
            YourPasswordHasBeenSent,

            /// <summary>
            /// Invalid Email Id.
            /// </summary>
            [Description("Invalid Email Id.")]
            InvalidEmailId,

            /// <summary>
            /// Email Verify Successfully
            /// </summary>
            [Description("Email verified successfully.")]
            EmailVerifySuccessfully,

            /// <summary>
            /// Email Verify Failed
            /// </summary>
            [Description("Email verification failed.")]
            EmailVerificationFailed,

            /// <summary>
            /// Email Id is not registered.
            /// </summary>
            [Description("Email Id is not registered.")]
            EmailIdNotRegistered,

            /// <summary>
            /// Email Send Failed
            /// </summary>
            [Description("Email send failed.")]
            EmailSendFailed,

            /// <summary>
            /// beneficiary add Success
            /// </summary>
            [Description("Beneficiary added successfully.")]
            BeneficiaryAddSuccess,

            /// <summary>
            /// beneficiary add Failed
            /// </summary>
            [Description("Beneficiary add failed.")]
            BeneficiaryAddFailed,

            /// <summary>
            /// beneficiary already added as beneficiary
            /// </summary>
            [Description("Already added as beneficiary.")]
            BeneficiaryAlreadyAdded,

            /// <summary>
            /// beneficiary not Cyber world user
            /// </summary>
            [Description("This Mobile Number is not having cyberworld account.")]
            BeneficiaryNotUser,

            /// <summary>
            /// beneficiary delete success
            /// </summary>
            [Description("Beneficiary deleted successfully.")]
            BeneficiaryDeleteSuccess,

            /// <summary>
            /// beneficiary delete fail
            /// </summary>
            [Description("Beneficiary delete failed.")]
            BeneficiaryDeleteFail,

            /// <summary>
            /// QR Code Return Success
            /// </summary>
            [Description("QR code return successfully.")]
            QRCodeReturnSuccess,

            /// <summary>
            /// QR Code not found
            /// </summary>
            [Description("QR code not found.")]
            QRCodeNotFound,

            /// <summary>
            /// QR Code not valid or used
            /// </summary>
            [Description("This QR code amount is paid.")]
            QRCodeNotValidOrUsed,

            /// <summary>
            /// QR Code Return Success
            /// </summary>
            [Description("QR code shared successfully.")]
            QRCodeShareSuccess,

            /// <summary>
            /// User is not registered with Cyber world.
            /// </summary>
            [Description("User is not registered with cyberworld.")]
            UserNotRegisterWithCyberWorld,

            /// <summary>
            /// Device Update Success
            /// </summary>
            [Description("Device updated successfully.")]
            DeviceUpdateSuccess,

            /// <summary>
            /// Device Update fail
            /// </summary>
            [Description("Device update failed.")]
            DeviceUpdateFail,

            /// <summary>
            /// sales representative add Success
            /// </summary>
            [Description("SR/DB user added successfully.")]
            SalesRepresentativeAddSuccess,

            /// <summary>
            /// sales representative update Success
            /// </summary>
            [Description("SR/DB user updated successfully.")]
            SalesRepresentativeUpdateSuccess,

            /// <summary>
            /// Sales representative add Failed
            /// </summary>
            [Description("Sales representative add failed.")]
            SalesRepresentativeAddFailed,

            /// <summary>
            /// Sales representative already added as beneficiary
            /// </summary>
            [Description("Already added as sales representative.")]
            SalesRepresentativeAlreadyAdded,

            /// <summary>
            /// Sales representative  delete success
            /// </summary>
            [Description("Sales representative deleted successfully.")]
            SalesRepresentativeDeleteSuccess,

            /// <summary>
            /// Sales representative  delete fail
            /// </summary>
            [Description("Sales representative delete failed.")]
            SalesRepresentativeDeleteFail,

            /// <summary>
            /// Sales representative  blocked success
            /// </summary>
            [Description("Sales representative blocked successfully.")]
            SalesRepresentativeBlockSuccess,

            /// <summary>
            /// Sales representative  blocked fail
            /// </summary>
            [Description("Sales representative block failed.")]
            SalesRepresentativeBlockFail,

            /// <summary>
            /// Sales representative  change status fail
            /// </summary>
            [Description("Sales representative status change failed.")]
            SalesRepresentativeChangeStatusFail,

            /// <summary>
            /// Sales representative  status change success
            /// </summary>
            [Description("Sales representative status changed successfully")]
            SalesRepresentativeChangeStatusSuccess,

            /// <summary>
            /// The change pin success
            /// </summary>
            [Description("Pin changed successfully.")]
            ChangePinSuccess,

            /// <summary>
            /// The change pin fail
            /// </summary>
            [Description("Pin change failed.")]
            ChangePinFail,

            /// <summary>
            /// The old pin incorrect
            /// </summary>
            [Description("Please enter valid old pin.")]
            OldPinIncorrect,

            /// <summary>
            /// Old PIN and New PIN could not be same
            /// </summary>
            [Description("Old PIN and New PIN could not be same.")]
            OldPinNewPinNotSame,

            /// <summary>
            /// Pin save successfully
            /// </summary>
            [Description("Pin saved successfully.")]
            PinSaveSuccess,

            /// <summary>
            /// Pin save failed
            /// </summary>
            [Description("Pin save failed.")]
            PinSaveFailed,

            /// <summary>
            /// Invalid Token Request
            /// </summary>
            [Description("Invalid token request.")]
            TokenInvalid,

            /// <summary>
            /// Contact save success
            /// </summary>
            [Description("Thank you for contacting Cyberworld, we will get back to you soon.")]
            ContactUsSaveSuccess,

            /// <summary>
            /// Contact save failed
            /// </summary>
            [Description("Please add valid details.")]
            ContactUsSaveFailed,

            /// <summary>
            /// GiftCardType delete success
            /// </summary>
            [Description("GiftCardType Deleted Successfully.")]
            GiftCardTypeDeleteSuccess,

            /// <summary>
            /// GiftCardType delete Fail
            /// </summary>
            [Description("GiftCardType Delete Failed.")]
            GiftCardTypeDeleteFail,

            /// <summary>
            /// FAQAnswer delete Success
            /// </summary>
            [Description("FAQ Answer Deleted Successfully.")]
            FAQAnswerDeleteSuccess,

            /// <summary>
            /// FAQAnswer delete Fail
            /// </summary>
            [Description("FAQ Answer Delete Failed.")]
            FAQAnswerDeleteFail,

            /// <summary>
            /// FAQCategory delete Success
            /// </summary>
            [Description("FAQ Category Deleted Successfully.")]
            FAQCategoryDeleteSuccess,

            /// <summary>
            /// FAQCategory delete Fail
            /// </summary>
            [Description("FAQ Category Delete Failed.")]
            FAQCategoryDeleteFail,

            /// <summary>
            /// FAQCategory add Success
            /// </summary>
            [Description("FAQ Category Added Successfully.")]
            FAQCategoryAddSucess,

            /// <summary>
            /// FAQCategory add Fail
            /// </summary>
            [Description("FAQ Category Add Failed.")]
            FAQCategoryAddFail,

            /// <summary>
            /// FAQCategory already added as beneficiary
            /// </summary>
            [Description("Already Added As FAQ Category.")]
            FAQCategoryAlreadyAdded,

            /// <summary>
            ///  FAQCategory Update Success
            /// </summary>
            [Description("FAQ Category Updated Successfully.")]
            FAQCategoryUpdateSuccess,

            /// <summary>
            /// FAQCategory not cyber world user
            /// </summary>
            [Description("this user not use cyberworld app.")]
            FAQCAtegoryNotUser,

            /// <summary>
            /// GiftCardType add Success
            /// </summary>
            [Description("GiftCardType Added Successfully.")]
            GiftCardTypeAddSuccess,

            /// <summary>
            /// GiftCardType add Fail
            /// </summary>
            [Description("GiftCardType Add Failed.")]
            GiftCardtypeAddFail,

            /// <summary>
            /// GiftCardType already added as beneficiary
            /// </summary>
            [Description("Already Added As GiftCardType.")]
            GiftCardTypeAlreadyAdded,

            /// <summary>
            /// GiftCardType not cyber world user
            /// </summary>
            [Description("this user not use cyberworld app.")]
            GiftCardNotUser,

            /// <summary>
            /// GiftCardType Update Success
            /// </summary>
            [Description("GiftCardType Updated Successfully.")]
            GiftCardTypeUpdateSuccess,

            /// <summary>
            /// FAQCategory add Success
            /// </summary>
            [Description("SubAdmin Added Successfully.")]
            SubAdminAddSuccess,

            /// <summary>
            /// FAQCategory add Fail
            /// </summary>
            [Description("SubAdmin Add Failed.")]
            SubAdminAddFail,

            /// <summary>
            /// FAQCategory already added as beneficiary
            /// </summary>
            [Description("Already Added As SubAdmin.")]
            SubAdminAlreadyAdded,

            /// <summary>
            /// FAQCategory not cyber world user
            /// </summary>
            [Description("this user not use cyberworld app.")]
            SubAdminNotUser,

            /// <summary>
            /// SubAdmin Update Success
            /// </summary>
            [Description("SubAdmin Updated Successfully.")]
            SubAdminUpdateSuccess,

            /// <summary>
            /// SubAdmin delete success
            /// </summary>
            [Description("SubAdmin Deleted Successfully.")]
            SubAdminDeleteSuccess,

            /// <summary>
            /// SubAdmin delete Fail
            /// </summary>
            [Description("SubAdmin Delete Failed.")]
            SubAdminDeleteFail,

            /// <summary>
            /// Country add Success
            /// </summary>
            [Description("Country Added Successfully.")]
            CountryAddSucess,

            /// <summary>
            /// Country add Fail
            /// </summary>
            [Description("Country Add Failed.")]
            CountryAddFail,

            /// <summary>
            /// Country already added
            /// </summary>
            [Description("Already Added As Country.")]
            CountryAlreadyAdded,

            /// <summary>
            /// Country not cyber world user
            /// </summary>
            [Description("this user not use cyberworld app.")]
            CountryNotUser,

            /// <summary>
            /// Country Update Success
            /// </summary>
            [Description("Country Updated Successfully.")]
            CountryUpdateSuccess,

            /// <summary>
            /// Country Delete Success
            /// </summary>
            [Description("Country Deleted Successfully.")]
            CountryDeleteSuccess,

            /// <summary>
            /// Country delete Fail
            /// </summary>
            [Description("Country Delete Failed.")]
            CountryDeleteFail,

            /// <summary>
            /// Province add Success
            /// </summary>
            [Description("Province Added Successfully.")]
            ProvinceAddSuccess,

            /// <summary>
            /// Province add Fail
            /// </summary>
            [Description("Province Add Failed.")]
            ProvinceAddFail,

            /// <summary>
            /// Province already 
            /// </summary>
            [Description("Already Added As Province.")]
            ProvinceAlreadyAdded,

            /// <summary>
            /// Province Update Success
            /// </summary>
            [Description("Province Updated Successfully.")]
            ProvinceUpdateSuccess,

            /// <summary>
            /// Province Deleted Successfully
            /// </summary>
            [Description("Province Deleted Successfully.")]
            ProvinceDeleteSuccess,

            /// <summary>
            /// Province delete Fail
            /// </summary>
            [Description("Province Delete Failed.")]
            ProvinceDeleteFail,

            /// <summary>
            /// Town add Success
            /// </summary>
            [Description("Town Added Successfully.")]
            TownAddSucess,

            /// <summary>
            /// Town add Fail
            /// </summary>
            [Description("Town Add Failed.")]
            TownAddFail,

            /// <summary>
            /// Town already added
            /// </summary>
            [Description("Already Added As Town.")]
            TownAlreadyAdded,

            /// <summary>
            /// Town Update Success
            /// </summary>
            [Description("Town Updated Successfully.")]
            TownUpdateSuccess,

            /// <summary>
            /// Town Deleted Successfully
            /// </summary>
            [Description("Town Deleted Successfully.")]
            TownDeleteSuccess,

            /// <summary>
            /// Town delete Fail
            /// </summary>
            [Description("Town delete failed.")]
            TownDeleteFail,

            /// <summary>
            /// ZipCode add Success
            /// </summary>
            [Description("ZipCode Added Successfully.")]
            ZipCodeAddSucess,

            /// <summary>
            /// ZipCode add Fail
            /// </summary>
            [Description("ZipCode Add Failed.")]
            ZipCodeAddFail,

            /// <summary>
            /// ZipCode already added
            /// </summary>
            [Description("Already Added As ZipCode.")]
            ZipCodeAlreadyAdded,

            /// <summary>
            /// ZipCode Update Success
            /// </summary>
            [Description("ZipCode Updated Successfully.")]
            ZipCodeUpdateSuccess,

            /// <summary>
            /// ZipCode Deleted Successfully
            /// </summary>
            [Description("ZipCode Deleted Successfully.")]
            ZipCodeDeleteSuccess,

            /// <summary>
            /// ZipCode delete Fail
            /// </summary>
            [Description("ZipCode Delete Failed.")]
            ZipCodeDeleteFail,

            /// <summary>
            /// Discount Deleted Successfully
            /// </summary>
            [Description("Discount Deleted Successfully.")]
            DiscountDeleteSuccess,

            /// <summary>
            /// ZipCode delete Fail
            /// </summary>
            [Description("Discount Delete Failed.")]
            DiscountDeleteFail,

            /// <summary>
            /// FAQ add Success
            /// </summary>
            [Description("FAQ Added Successfully.")]
            FAQAddSucess,

            /// <summary>
            /// FAQ add Fail
            /// </summary>
            [Description("FAQ Add Failed.")]
            FAQAddFail,

            /// <summary>
            /// FAQ already added as beneficiary
            /// </summary>
            [Description("Already Added as FAQ.")]
            FAQAlreadyAdded,

            /// <summary>
            /// FAQ not cyber world user
            /// </summary>
            [Description("this user not use cyberworld app.")]
            FAQNotUser,

            /// <summary>
            /// FAQ Update Success
            /// </summary>
            [Description("FAQ Updated Successfully.")]
            FAQUpdateSuccess,

            /// <summary>
            /// FAQ Deleted Successfully
            /// </summary>
            [Description("FAQ Deleted Successfully.")]
            FAQDeleteSuccess,

            /// <summary>
            /// FAQ delete Fail
            /// </summary>
            [Description("FAQ Delete Failed.")]
            FAQDeleteFail,

            /// <summary>
            /// Agreement add Success
            /// </summary>
            [Description("Agreement Added Successfully.")]
            AgreementAddSucess,

            /// <summary>
            /// Agreement add Fail
            /// </summary>
            [Description("Agreement Add Failed.")]
            AgreementAddFail,

            /// <summary>
            /// Town already added
            /// </summary>
            [Description("Already Added As Agreement.")]
            AgreementAlreadyAdded,

            /// <summary>
            /// Town Update Success
            /// </summary>
            [Description("Agreement Updated Successfully.")]
            AgreementUpdateSuccess,

            /// <summary>
            /// Town delete success
            /// </summary>
            [Description("Agreement Deleted Successfully.")]
            AgreementDeleteSuccess,

            /// <summary>
            /// Agreement delete Fail
            /// </summary>
            [Description("Agreement Delete Failed.")]
            AgreementDeleteFail,

            /// <summary>
            /// CorporateBusinessDetail Update Success
            /// </summary>
            [Description("CorporateBusinessDetail Updated Successfully.")]
            CorporateBusinessDetailUpdateSuccess,

            /// <summary>
            /// CorporateBusinessDetail add Fail
            /// </summary>
            [Description("CorporateBusinessDetail Add Failed.")]
            CorporateBusinessDetailAddFail,

            /// <summary>
            /// CorporateBusinessDetail Already Added
            /// </summary>
            [Description("Already Added As CorporateBusinessDetail.")]
            CorporateBusinessDetailAlreadyAdded,

            /// <summary>
            /// Application add Success
            /// </summary>
            [Description("Application Added Successfully.")]
            ApplicationAddSucess,

            /// <summary>
            /// Application add Fail
            /// </summary>
            [Description("Application Add Failed.")]
            ApplicationAddFail,

            /// <summary>
            /// Application already added
            /// </summary>
            [Description("Already Added As Application.")]
            ApplicationAlreadyAdded,

            /// <summary>
            /// Application not cyber world user
            /// </summary>
            [Description("this user not use cyberworld app.")]
            ApplicationNotUser,

            /// <summary>
            /// Application Update Success
            /// </summary>
            [Description("Application Updated Successfully.")]
            ApplicationUpdateSuccess,

            /// <summary>
            /// Application delete success
            /// </summary>
            [Description("Application Deleted Successfully.")]
            ApplicationDeleteSuccess,

            /// <summary>
            /// Application delete Fail
            /// </summary>
            [Description("Application Delete Failed.")]
            ApplicationDeleteFail,

            /// <summary>
            /// Page add Success
            /// </summary>
            [Description("Page Added Successfully.")]
            PageAddSucess,

            /// <summary>
            /// Page add Fail
            /// </summary>
            [Description("Page Add Failed.")]
            PageAddFail,

            /// <summary>
            /// Page already added 
            /// </summary>
            [Description("Already Added As Page.")]
            PageAlreadyAdded,

            /// <summary>
            ///  Page Update Success
            /// </summary>
            [Description("Page Updated Successfully.")]
            PageUpdateSuccess,

            /// <summary>
            /// Page not cyber world user
            /// </summary>
            [Description("this user not use cyberworld app.")]
            PageNotUser,

            /// <summary>
            /// Page delete Success
            /// </summary>
            [Description("Page Deleted Successfully.")]
            PageDeleteSuccess,

            /// <summary>
            /// Page delete Fail
            /// </summary>
            [Description("Page Delete Failed.")]
            PageDeleteFail,

            /// <summary>
            /// User Blocked 
            /// </summary>
            [Description("User Blocked Successfully")]
            UserBlockedSuccess,

            /// <summary>
            /// User Blocked 
            /// </summary>
            [Description("User UnBlocked Successfully")]
            UserUnBlockedSuccess,

            /// <summary>
            /// User Activated
            /// </summary>
            [Description("User Activated Successfully")]
            UserActivatedSuccess,

            /// <summary>
            /// User DeActivated
            /// </summary>
            [Description("User Inactivated Successfully")]
            UserDeActivatedSuccess,

            /// <summary>
            /// User Accepted
            /// </summary>
            [Description("User Approved Successfully")]
            UserAcceptedSuccess,

            /// <summary>
            /// User Rejected
            /// </summary>
            [Description("User Rejected Successfully")]
            UserRejectedSuccess,

            /// <summary>
            /// Image add Success
            /// </summary>
            [Description("Image Added Successfully.")]
            ImageAddSuccess,

            /// <summary>
            /// Image add Fail
            /// </summary>
            [Description("Image Add Failed.")]
            ImageAddFail,

            /// <summary>
            /// Image already 
            /// </summary>
            [Description("Image Added as Image.")]
            ImageAlreadyAdded,

            /// <summary>
            /// PrivacyPolicy add Success
            /// </summary>
            [Description("Privacy Policy Added Successfully.")]
            PrivacyPolicyAddSucess,

            /// <summary>
            /// TermsAndCondition add Success
            /// </summary>
            [Description("Terms & Condition Added Successfully.")]
            TermsAndConditionAddSucess,

            /// <summary>
            /// PrivacyPolicy already added
            /// </summary>
            [Description("Already Added As PrivacyPolicy.")]
            PrivacyPolicyAlreadyAdded,

            /// <summary>
            /// TermsAndCondition already added
            /// </summary>
            [Description("Already Added As Terms&Condition.")]
            TermsAndConditionAlreadyAdded,

            /// <summary>
            /// PrivacyPolicy add Fail
            /// </summary>
            [Description("Privacy Policy Add Failed.")]
            PrivacyPolicyAddFail,

            /// <summary>
            /// TermsAndCondition add Fail
            /// </summary>
            [Description("Terms & Condition Add Failed.")]
            TermsAndConditionAddFail,

            /// <summary>
            /// PrivacyPolicy Update Success
            /// </summary>
            [Description("Privacy Policy Updated Successfully.")]
            PrivacyPolicyUpdateSuccess,

            /// <summary>
            /// TermsAndCondition Update Success
            /// </summary>
            [Description("Terms & Condition Updated Successfully.")]
            TermsAndConditionUpdateSuccess,

            /// <summary>
            /// PrivacyPolicy delete success
            /// </summary>
            [Description("Privacy Policy Deleted Successfully.")]
            PrivacyPolicyDeleteSuccess,

            /// <summary>
            /// TermsAndCondition delete success
            /// </summary>
            [Description("Terms & Condition Deleted Successfully.")]
            TermsAndConditionDeleteSuccess,

            /// <summary>
            /// PrivacyPolicy delete Fail
            /// </summary>
            [Description("Privacy Policy Delete Failed.")]
            PrivacyPolicyDeleteFail,

            /// <summary>
            /// TermsAndCondition delete Fail
            /// </summary>
            [Description("Terms & Condition Delete Failed.")]
            TermsAndConditionDeleteFail,

            /// <summary>
            /// Business Category add Success
            /// </summary>
            [Description("Business Category Added Successfully.")]
            BusinessCategoryAddSucess,

            /// <summary>
            /// FAQ add Fail
            /// </summary>
            [Description("Business Category Add Failed.")]
            BusinessCategoryAddFail,

            /// <summary>
            /// FAQ already added as beneficiary
            /// </summary>
            [Description("Already Added as Business Category.")]
            BusinessCategoryAlreadyAdded,

            /// <summary>
            /// FAQ Update Success
            /// </summary>
            [Description("Business Category Updated Successfully.")]
            BusinessCategoryUpdateSuccess,

            /// <summary>
            /// Business Category Status Update Success
            /// </summary>
            [Description("Business Category Status Updated Successfully.")]
            BusinessCategoryStatusUpdateSuccess,

            /// <summary>
            /// Business Category Status Update Fail
            /// </summary>
            [Description("Business Category Status Add Fail.")]
            BusinessCategoryStatusUpdateFail,

            /// <summary>
            /// Wallet Create Success
            /// </summary>
            [Description("Wallet created successfully.")]
            WalletCreateSuccess,

            /// <summary>
            /// Wallet Create failed
            /// </summary>
            [Description("Wallet create failed.")]
            WalletCreateFail,

            /// <summary>
            /// Wallet TopUp Success
            /// </summary>
            [Description("Wallet topup successfully.")]
            WalletTopupSuccess,

            /// <summary>
            /// Wallet TopUp failed
            /// </summary>
            [Description("Wallet topup failed.")]
            WalletTopupFail,

            /// <summary>
            /// Wallet TopUp status update Success
            /// </summary>
            [Description("Wallet topup status updated successfully.")]
            WalletTopupUpdateStatusSuccess,

            /// <summary>
            /// Wallet TopUp status update failed
            /// </summary>
            [Description("Wallet topup status update failed.")]
            WalletTopupUpdateStatusFail,

            /// <summary>
            /// Wallet Transfer Success
            /// </summary>
            [Description("Wallet money transfer successfully.")]
            WalletTransferSuccess,

            /// <summary>
            /// Wallet Transfer Fail
            /// </summary>
            [Description("Wallet money transfer failed.")]
            WalletTransferFail,

            /// <summary>
            /// from User not create cyber world wallet account
            /// </summary>
            [Description("This Mobile Number is not having cyberworld account.")]
            FromUserWalletNotCreated,

            /// <summary>
            /// To User not create cyber world wallet account
            /// </summary>
            [Description("This Mobile Number is not having cyberworld account.")]
            ToUserWalletNotCreated,

            /// <summary>
            /// User not create cyber world wallet account
            /// </summary>
            [Description("you have not created cyberworld wallet account.")]
            WalletNotCreated,

            /// <summary>
            /// To User not create cyber world wallet account
            /// </summary>
            [Description("You can not send money from your wallet to your own wallet.")]
            SameWalletMoneyTransfer,

            /// <summary>
            /// Bill Payment successfully
            /// </summary>
            [Description("Bill payment successfully.")]
            BillPaymentSuccess,

            /// <summary>
            /// Bill Payment Fail
            /// </summary>
            [Description("Bill payment failed.")]
            BillPaymentFail,

            /// <summary>
            /// Bill Payment Processing
            /// </summary>
            [Description("Bill payment in Processing.")]
            BillPaymentProcessing,

            /// <summary>
            /// Bill Payment status update success
            /// </summary>
            [Description("Transaction successfully.")]
            BillPaymentStatusUpdateSuccess,

            /// <summary>
            /// Bill Payment status update Fail
            /// </summary>
            [Description("Transaction failed.")]
            BillPaymentStatusUpdateFail,

            /// <summary>
            /// BusinessIndustry add Success
            /// </summary>
            [Description("Biller Category Added Successfully.")]
            BusinessIndustryAddSucess,

            /// <summary>
            /// Application add Fail
            /// </summary>
            [Description("Biller Category Add Failed.")]
            BusinessIndustryAddFail,

            /// <summary>
            /// Application already added
            /// </summary>
            [Description("Already Added As Biller Category.")]
            BusinessIndustryAlreadyAdded,

            /// <summary>
            /// Business Industry Update Success
            /// </summary>
            [Description("Biller Category Updated Successfully.")]
            BusienssIndustryUpdateSuccess,

            /// <summary>
            /// Application delete success
            /// </summary>
            [Description("Biller Category Deleted Successfully.")]
            BusinessIndustryDeleteSuccess,

            /// <summary>
            /// Application delete Fail
            /// </summary>
            [Description("Biller Category Delete Failed.")]
            BusinessIndustryDeleteFail,

            /// <summary>
            /// Discount add Success
            /// </summary>
            [Description("Discount Added Successfully.")]
            DiscountAddSucess,

            /// <summary>
            /// Discount add Fail
            /// </summary>
            [Description("Discount Add Fail.")]
            DiscountAddFail,

            /// <summary>
            /// Discount Update Success
            /// </summary>
            [Description("Discount Updated Successfully.")]
            DiscountUpdateSuccess,

            /// <summary>
            /// Discount Status Update Success
            /// </summary>
            [Description("Discount Status Updated Successfully.")]
            DiscountStatusUpdateSuccess,

            /// <summary>
            /// Discount Status Update Fail
            /// </summary>
            [Description("Discount Status Add Fail.")]
            DiscountStatusUpdateFail,

            /// <summary>
            /// RoleRights add Success
            /// </summary>
            [Description("Role Added Successfully.")]
            RoleRightsAddSucess,

            /// <summary>
            /// RoleRights add Fail
            /// </summary>
            [Description("Role Add Failed.")]
            RoleRightsAddFail,

            /// <summary>
            /// RoleRights already added as beneficiary
            /// </summary>
            [Description("Already Added as Role.")]
            RoleRightsAlreadyAdded,

            /// <summary>
            /// RoleRights Update Success
            /// </summary>
            [Description("Role Updated Successfully.")]
            RoleRightsUpdateSuccess,

            /// <summary>
            /// RoleRights delete success
            /// </summary>
            [Description("Role Deleted Successfully.")]
            RoleRightsDeleteSuccess,

            /// <summary>
            /// RoleRights delete Fail
            /// </summary>
            [Description("Role Delete Failed.")]
            RoleRightsDeleteFail,

            /// <summary>
            /// RoleRights AssignToUser
            /// </summary>
            [Description("This role can not be deleted due to assigned to user.")]
            RoleRightsAssignToUser,

            /// <summary>
            /// Role not exist 
            /// </summary>
            [Description("Role not exist please select valid role.")]
            RoleIdNotExist,

            /// <summary>
            /// Role add Success
            /// </summary>
            [Description("Role Added Successfully.")]
            RoleAddSucess,

            /// <summary>
            /// Role add Fail
            /// </summary>
            [Description("Role Add Failed.")]
            RoleAddFail,

            /// <summary>
            /// Application already added
            /// </summary>
            [Description("Already Added As Role.")]
            RoleAlreadyAdded,

            /// <summary>
            /// Role Updated Successfully
            /// </summary>
            [Description("Role Updated Successfully.")]
            RoleUpdateSuccess,

            /// <summary>
            /// Application delete success
            /// </summary>
            [Description("Role Deleted Successfully.")]
            RoleDeleteSuccess,

            /// <summary>
            /// Application delete Fail
            /// </summary>
            [Description("Role Delete Failed.")]
            RoleDeleteFail,

            /// <summary>
            /// Discount already assign
            /// </summary>
            [Description("We could not delete record(s), We found reference of your request.")]
            DiscountAlreadyAssign,

            /// <summary>
            /// Pay for me send request success
            /// </summary>
            [Description("Payment request send successfully.")]
            PayForMeSendSuccess,

            /// <summary>
            /// Pay for me send request fail
            /// </summary>
            [Description("Payment request send failed.")]
            PayForMeSendFail,

            /// <summary>
            /// Pay for me request accept reject success
            /// </summary>
            [Description("Payment request accepted successfully.")]
            PayForMeAcceptSuccess,

            /// <summary>
            /// Pay for me request reject success
            /// </summary>
            [Description("Payment request rejected successfully.")]
            PayForMeAcceptRejectSuccess,

            /// <summary>
            /// Pay for me request accept reject fail
            /// </summary>
            [Description("Payment request accept reject failed.")]
            PayForMeAcceptRejectFailed,

            /// <summary>
            /// Pay for me from and to user same
            /// </summary>
            [Description("Please select to user different from, from user.")]
            PayForMeFromToSameUser,

            /// <summary>
            /// Pay for me from and receiver user same
            /// </summary>
            [Description("Please select receiver user different from, from user.")]
            PayForMeFromReceiverSameUser,

            /// <summary>
            /// Pay for me to and receiver user same
            /// </summary>
            [Description("Please select to user different from, receiver user.")]
            PayForMeToReceiverSameUser,

            /// <summary>
            /// The login failed
            /// </summary>
            [Description("You are not allowed to access admin panel.")]
            NotAllowedAdminPanel,

            /// <summary>
            /// Notification add Success
            /// </summary>
            [Description("Notification Send Successfully.")]
            NotificationSendSuccess,

            /// <summary>
            /// Notification add Fail
            /// </summary>
            [Description("Notification Send Failed.")]
            NotificationSendFail,

            /// <summary>
            /// Notification delete success
            /// </summary>
            [Description("Notification Deleted Successfully.")]
            NotificationDeleteSuccess,

            /// <summary>
            /// Notification delete Fail
            /// </summary>
            [Description("Notification Delete Failed.")]
            NotificationDeleteFail,

            /// <summary>
            /// Notification add Success
            /// </summary>
            [Description("Notification ReSend Successfully.")]
            NotificationReSendSuccess,

            /// <summary>
            /// Notification add Fail
            /// </summary>
            [Description("Notification ReSend Failed.")]
            NotificationReSendFail,

            /// <summary>
            /// Schedule Create Success
            /// </summary>
            [Description("Schedule Created Successfully.")]
            ScheduleRequestSuccess,

            /// <summary>
            /// Schedule Create Fail
            /// </summary>
            [Description("Schedule Create Failed.")]
            ScheduleRequestFail,

            #region "Message Correction Nakul"
            [Description("Examination Details are Not Found,Please Try Again.")]
            ExaminationData,

            [Description("Data Not Insert. ")]
            DataInserted,
            [Description("Data Not Updated. ")]
            DataUpdated,

            [Description("User Activated Successfully.")]
            UserActivated,

            [Description("Aadhaar Service Is Not Responding, Please Try Again.")]
            AadhaarAuthenticationFailed,

            [Description("Emitra Service Is Not Responding, Please Try Again.")]
            EmitraBackToBackFailed
            #endregion
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <param name="systemMessage">The system message.</param>
        /// <returns>System String.</returns>
        public static string GetMessage(SystemMessages systemMessage)
        {
            return GetEnumDescription(systemMessage);
        }

        /// <summary>
        /// Gets the ENUM description.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System String.</returns>
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);

            if (attributes != null &&
                attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
