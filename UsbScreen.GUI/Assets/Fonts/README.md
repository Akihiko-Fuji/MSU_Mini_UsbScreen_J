# 日本語表示フォント

LCDの日本語表示には、**JFドットM+H12**を使用します。

1. [自家製ドットフォントシリーズ](http://jikasei.me/font/jf-dotfont/)からフォントを入手する。
2. `JF-Dot-MPlusH12.ttf` をこのディレクトリへ配置する。
3. `UsbScreen.GUI` をビルドまたは発行する。

配置先:

```text
UsbScreen.GUI/Assets/Fonts/JF-Dot-MPlusH12.ttf
```

フォントファイルは `.gitignore` の対象であり、リポジトリには含めません。
Avaloniaのリソースはビルド時に組み込まれるため、フォントを配置した後に
必ず再ビルドしてください。

> `JF-Dot-MPlusH12.ttf` のフォントファミリー名は「JFドットM+H12」です。
> 「JFドット東雲明朝12」とは別の書体です。
