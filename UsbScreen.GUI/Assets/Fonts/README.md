# 日本語表示フォント

LCDの日本語表示には、**JFドットM+H12**を使用します。

1. [自家製ドットフォントシリーズの公式HTTPSページ](https://jikasei.me/font/jf-dotfont/)からフォントを入手する。
   第三者のミラーサイトからは入手しない。配布元がチェックサムまたは署名を公開している
   場合は、配置前に必ず照合する。SHA-256はPowerShellでは
   `Get-FileHash <ダウンロードファイル> -Algorithm SHA256`、Linuxでは
   `sha256sum <ダウンロードファイル>`で確認できる。現時点で公式の固定チェックサムを
   確認できないため、本リポジトリには未検証の値を掲載しない。
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
