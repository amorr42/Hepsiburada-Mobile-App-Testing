Feature: AddBasket
	

@regression
Scenario Outline: Sepete Ürün ekleme
	#Given Hepsiburada Mobile App uygulamasi acilir. Profil butonuna tiklanir.
	#When  Giris yap butonuna tiklanir.
	#Then  Email "testhepsiburada0@gmail.com" girilir.
	#Then  Sifre "Pork1234" girilir. 
	#Then  Güvenli Giris butonuna tiklanir.
	#Then  Alert Mesaji onaylanir.
	Given Arama ekranina gidilir.
	When  Aranacak ürünün adi "bilgisayar" girilir ve arama yapilir.
	When Filtrele butonuna tiklanir.
	Then <Kategori> Kategori secilir.
	Then <UrünCesidi> Urün Cesidi secilir.
	Then <FiyatAraligi> Fiyat Araligi secilir.
	Then <DegerlendirmePuani> Degerlendirme Puani secilir.
	Then <Marka> Marka secilir.
	Then <KullanimAmaci> Kullanim Amaci secilir.
	Then <FirsatUrünleri> Firsat Urünleri secilir.
	Then <İslemciTipi> İslemci Tipi secilir.
	Then <EkranBoyutu> Ekran Boyutu secilir.
	#Then <EkranKartiHafizasi> Ekran Karti Hafizasi secilir.
	Then <SSDKapasitesi> SSD Kapasitesi secilir.
	Then <MaxEkranCözünürlügü> Max Ekran Cözünürlügü secilir. 
	Then <CihazAgirligi> Cihaz Agirligi secilir.
	#Then <EkranKarti> Ekran Karti secilir.
	Then Urünleri gör butonuna tiklanir ve ürün sepete eklenir.
	Then Sepete gidilir.

Examples: 
	| Kategori   | UrünCesidi                | FiyatAraligi     | DegerlendirmePuani     | Marka  | KullanimAmaci | FirsatUrünleri    | İslemciTipi   | EkranBoyutu | EkranKartiHafizasi | SSDKapasitesi | MaxEkranCözünürlügü | CihazAgirligi | EkranKarti         |
	| Bilgisayar | Dizüstü Bilgisayar Laptop | 2500 TL Üzerinde | 4 ve 4+ puanlı ürünler | Lenovo | Ofis ve İş    | 24 Saatte Kargoda | Intel Core i7 | 15,6 inç    | Paylaşımlı		 | 512 GB        | 1920 x 1080         | 2 kg ve Altı  | Intel Iris Graphic |
							
	