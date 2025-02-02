# EmreCrosshair
# Crosshair Application / Nişangâh Uygulaması
![image](https://github.com/qweemree/EmreCrosshair/assets/164534188/7c6db0fd-cb7e-42fc-8e7a-fdeebbe3afde)

This is a customizable crosshair overlay application developed in C#. It allows users to create a crosshair overlay on their screen with various customization options, including size, color, thickness, gap, border, and opacity.

Bu, C# ile geliştirilen özelleştirilebilir bir nişangâh kaplama uygulamasıdır. Kullanıcıların ekranlarında boyut, renk, kalınlık, boşluk, kenarlık ve opaklık dahil çeşitli özelleştirme seçenekleriyle bir nişangâh kaplaması oluşturmasına olanak tanır.

# Install 
[Setup for EmreCrosshair](https://github.com/emredotnet/EmreCrosshair/releases/download/release/SetupEC.msi)

# Features / Özellikler
- Customizable crosshair size / Özelleştirilebilir nişangâh boyutu
- Adjustable gap between crosshair lines / Nişangâh çizgileri arasındaki boşluğu ayarlayabilme
- Configurable crosshair line thickness / Nişangâh çizgisi kalınlığını ayarlayabilme
- Optional border around the crosshair / Nişangâh çevresinde isteğe bağlı kenarlık
- Support for different colors and RGB customization / Farklı renkler ve RGB özelleştirmesi desteği
- Adjustable opacity for the crosshair / Nişangâh için ayarlanabilir opaklık
- Multi-language support (English and Turkish) / Çoklu dil desteği (İngilizce ve Türkçe)

# Requirements / Gereksinimler
- .NET Framework 4.7.2 or later / .NET Framework 4.7.2 veya daha üstü

# Usage / Kullanım
- Launch the application. / Uygulamayı başlatın.
- Customize the crosshair using the provided options: / Sağlanan seçenekleri kullanarak nişangâhı özelleştirin:
- Color: Choose from predefined colors or use the RGB sliders to create a custom color. / Önceden tanımlanmış renklerden birini seçin veya özel bir renk oluşturmak için RGB kaydırıcılarını kullanın.
- Size: Adjust the length of the crosshair lines. / Nişangâh çizgilerinin uzunluğunu ayarlayın.
- Gap: Set the gap between the center and the crosshair lines. / Merkez ile nişangâh çizgileri arasındaki boşluğu ayarlayın.
- Thickness: Adjust the thickness of the crosshair lines. / Nişangâh çizgilerinin kalınlığını ayarlayın.
- Border: Enable and set the thickness of the border around the crosshair lines. / Nişangâh çizgileri etrafındaki kenarlığı etkinleştirin ve kalınlığını ayarlayın.
- Opacity: Adjust the opacity of the crosshair overlay. / Nişangâh kaplamasının opaklığını ayarlayın.
- Click the Start button to display the crosshair on your screen. / Nişangâhı ekranınızda görüntülemek için Başlat düğmesine tıklayın.
- To hide the crosshair and return to the customization menu, double-click the system tray icon or use the menu options. / Nişangâhı gizlemek ve özelleştirme menüsüne dönmek için sistem tepsisi simgesine çift tıklayın veya menü seçeneklerini kullanın.

# Code Overview / Kodun Genel Bakışı
## MainFormEmreCrosshair

This form allows users to customize the crosshair and start the overlay. / Bu form, kullanıcıların nişangâhı özelleştirmesine ve kaplamayı başlatmasına olanak tanır.

radiocheck: Determines the selected color for the crosshair. / Nişangâh için seçilen rengi belirler.

startbutton_Click: Starts the crosshair overlay with the selected settings. / Seçilen ayarlarla nişangâh kaplamasını başlatır.

crossguncelle: Updates the crosshair preview in the panel. / Paneldeki nişangâh önizlemesini günceller.

menu: Shows the customization menu and hides the overlay. / Özelleştirme menüsünü gösterir ve kaplamayı gizler.

DrawCrosshair: Draws the crosshair in the preview panel. / Önizleme panelinde nişangâhı çizer.

Language Toggle: Switches between English and Turkish for the UI. / Kullanıcı arayüzü için İngilizce ve Türkçe arasında geçiş yapar.

## EmreCrosshair

This form creates the actual crosshair overlay. / Bu form, gerçek nişangâh kaplamasını oluşturur.

InitializeOverlay: Sets up the overlay properties. / Kaplama özelliklerini ayarlar.

OnPaint: Draws the crosshair with optional border on the screen. / Ekranda isteğe bağlı kenarlık ile nişangâhı çizer.

MakeFormClickThrough: Makes the form click-through and sets it as a layered window for transparency. / Formun tıklanabilir olmasını sağlar ve saydamlık için katmanlı bir pencere olarak ayarlar.

# Windows API Interactions / Windows API Etkileşimleri

The application uses Windows API to modify the form's extended window styles. / Uygulama, formun genişletilmiş pencere stillerini değiştirmek için Windows API kullanır.

GetWindowLong and SetWindowLong are used to retrieve and set the extended window styles. / GetWindowLong ve SetWindowLong, genişletilmiş pencere stillerini almak ve ayarlamak için kullanılır.

WS_EX_TRANSPARENT makes the form transparent to mouse events. / WS_EX_TRANSPARENT, formu fare olaylarına karşı saydam hale getirir.

WS_EX_LAYERED allows the form to have adjustable opacity. / WS_EX_LAYERED, formun ayarlanabilir opaklığa sahip olmasını sağlar.

# Contributions / Katkılar

Feel free to open issues or submit pull requests for any improvements or bug fixes.

Herhangi bir iyileştirme veya hata düzeltmesi için sorun açmaktan veya pull request göndermekten çekinmeyin.

