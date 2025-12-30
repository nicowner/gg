# MauiTestApp

Küçük bir .NET MAUI uygulaması örneği.

- Tema: **Siyah** (global)
- Ana sayfada logo: `Resources/Images/test.webp`
- Ekranda basılabilir **"Test"** butonu (tıklandığında uyarı gösterir)

Nasıl çalıştırılır:

1. .NET ve MAUI workload'u kurun (örn. .NET 8):
   - `dotnet workload install maui` (gerekli olabilir)
2. Proje dizinine gidin:
   - `cd MauiTestApp`
3. Android'de çalıştırmak için (cihaz veya emülatör bağlı):
   - `dotnet build -f net8.0-android`
   - `dotnet run -f net8.0-android`

Not: Bu repo örnek amaçlıdır; geliştirme ortamınıza göre SDK ve platform yüklemeleri gerekebilir.

Dosyalar:
- `MainPage.xaml` : Siyah tema, `test.webp` ve "Test" butonu.
- `Resources/Images/test.webp` : Küçük örnek webp içerik (base64 içeriği yerleştirildi).
