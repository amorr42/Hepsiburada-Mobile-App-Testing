Feature: LoginPage


@regression
Scenario: Hepsiburada LoginPage

	Given logInApp  Hepsiburada Mobile App uygulamasi acilir. Profil butonuna tiklanir.
	When  logInApp	Giris yap butonuna tiklanir.
	Then  logInApp  Email "testhepsiburada0@gmail.com" girilir.
	Then  logInApp  Sifre "Pork1234" girilir. 
	Then  logInApp  Güvenli Giris butonuna tiklanir.
	Then  logInApp  Alert Mesaji onaylanir.

