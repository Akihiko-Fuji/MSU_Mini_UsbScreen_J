# MSU Mini USB Screen Manager

<div align="center">

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20Linux-brightgreen.svg)
![.NET](https://img.shields.io/badge/.NET-10.0-purple.svg)
![Avalonia](https://img.shields.io/badge/UI-Avalonia-red.svg)
![AOT](https://img.shields.io/badge/Compiled-Native%20AOT-orange.svg)

**MSU Mini USB OLED/LCDスクリーンを日本語で管理するための派生版です。**

[日本語](#japanese) | [English](#english) | [简体中文](#zh-cn)

</div>

---

<a name="japanese"></a>

## 🌟 主な機能

### 🖥️ GUIマネージャー（UsbScreen.GUI）

* **日本語UI**: 新規環境では日本語を既定とし、設定から日本語・英語・簡体字中国語を選択できます。
* **ビジュアルデザイナー**: 160×80のキャンバスで表示内容を編集できます。
* **レイヤー機能**: 複数の文字レイヤーについて、位置、色、文字サイズ、フォントを設定できます。
* **動的変数**: `%CPU%`、`%RAM%`、`%TIME%`、`%DATE%`、`%INET%`を使用できます。
* **画像表示**: PNG、JPG、GIFに対応します。
* **プリセット**: 表示設定を保存・読込みできます。
* **タスクトレイ**: ウィンドウを閉じてもバックグラウンドで動作できます。

### 🔤 日本語表示フォント

LCDの日本語表示には**JFドットM+H12**（`JF-Dot-MPlusH12.ttf`）を使用します。
フォントファイルはこのリポジトリに含まれません。
新規の文字レイヤーとCLIの既定文字サイズは、ドットが最も自然に表示される12pxです。

1. [自家製ドットフォントシリーズ](http://jikasei.me/font/jf-dotfont/)からフォントを入手します。
2. 次の場所へ配置します。

   ```text
   UsbScreen.GUI/Assets/Fonts/JF-Dot-MPlusH12.ttf
   ```

3. フォントを配置した状態で`UsbScreen.GUI`をビルドまたは発行します。

Avaloniaはフォントをビルド時にアプリへ組み込むため、配置後の再ビルドが必要です。
CLIで既定フォントとして使う場合は、実行ファイルと同じ場所の
`Fonts/JF-Dot-MPlusH12.ttf`へ配置するか、環境変数`USBSCREEN_FONT_PATH`で
ファイルの絶対パスを指定してください。

> `JF-Dot-MPlusH12.ttf`の書体名は「JFドットM+H12」です。
> 「JFドット東雲明朝12」を使用する場合は、対象ファイルとファミリー名を変更する必要があります。

### 🚀 ビルド

```sh
dotnet build UsbScreen.sln
```

既に英語または中国語を保存している環境では、設定画面から「日本語」を選択して
アプリを再起動してください。

### 謝辞

本リポジトリは
[Blackwood416/MSU_Mini_UsbScreen](https://github.com/Blackwood416/MSU_Mini_UsbScreen)
を基にした日本語対応フォークです。原作者およびMori Studioに感謝します。

---

<a name="english"></a>

## 🌟 Features

### 🖥️ GUI Manager (UsbScreen.GUI)
*   **Visual Designer**: Real-time 160x80 canvas for crafting your screen layout.
*   **Layer System**: Add multiple text layers with custom positioning (X, Y), fonts, sizes, and colors.
*   **Dynamic Variables**: Real-time system monitoring. Use variables like `%CPU%`, `%RAM%`, `%TIME%`, `%DATE%`, and `%INET%`.
*   **Image Support**: Display static images (PNG, JPG) or animated GIFs.
*   **Slideshow Mode**: Automatically cycle through your favorite images.
*   **Presets**: Save and load your custom designs easily.
*   **System Tray**: Runs quietly in the background; minimize to tray for persistent monitoring.
*   **Multilingual**: Full support for Japanese, English, and Chinese.

### ⌨️ CLI Tool (UsbScreen.CLI)
*   **Lightweight**: Minimal footprint, perfect for scripts and automation.
*   **Native AOT**: Single-file executable with no dependencies (on Windows).
*   **Command Driven**: Send images, text, or flash firmware directly from the terminal.

---

## 🚀 Installation (Portable)

No installation is required. Simply download the `portable.zip` for your platform from the [Releases](https://github.com/Blackwood416/MSU_Mini_UsbScreen/releases) page.

### Windows (win-x64)
1. Download `usbscreen-gui-win-x64.zip` or `usbscreen-cli-win-x64.zip`.
2. Extract the contents.
3. Run `UsbScreen.GUI.exe` or `usb-screen.exe`.

### Linux (linux-x64 / linux-arm64)
1. Download the corresponding `.zip` for your architecture.
2. Ensure you have the necessary permissions: `chmod +x UsbScreen.GUI` or `chmod +x usb-screen`.
3. **Note**: For CLI/GUI to work on Linux, ensure the bundled `libSystem.IO.Ports.Native.so` is in the same directory as the executable.

---

## 🛠️ System Requirements
*   **Windows**: Windows 10/11 x64.
*   **Linux**: Modern distribution (Ubuntu, Debian, etc.) with `libSystem.IO.Ports.Native` dependencies if not using the bundled version.
*   **Hardware**: MSU Mini USB Screen (or compatible 160x80 serial screen).

---

<a name="zh-cn"></a>

## 🌟 功能特性 (简体中文)

### 🖥️ 图形界面管理器 (UsbScreen.GUI)
*   **可视化设计器**: 支持 160x80 画布实时预览，自由排版。
*   **图层系统**: 多文本图层支持，可自定义坐标 (X, Y)、字体、字号及颜色。
*   **动态变量**: 实时系统监控。支持变量如 `%CPU%`, `%RAM%`, `%TIME%`, `%DATE%`, `%INET%` 等。
*   **图片支持**: 支持显示静态图片 (PNG, JPG) 及动态 GIF。
*   **轮播模式**: 设定时间间隔，自动轮播多张图片。
*   **预设管理**: 轻松保存和加载您的设计方案。
*   **系统托盘**: 支持最小化到托盘，在后台静默运行。
*   **多语言支持**: 完整支持中英文界面。

### ⌨️ 命令行工具 (UsbScreen.CLI)
*   **轻量化**: 极小的体积，非常适合脚本编写和自动化。
*   **原生 AOT 编译**: 独立的可执行文件，启动飞快（Windows 下无依赖）。
*   **指令驱动**: 直接通过终端发送图片、文字或刷写固件。

---

## 🚀 安装指南 (绿色免安装)

本项目发布的所有版本均为绿色版，无需安装。请前往 [Releases](https://github.com/Blackwood416/MSU_Mini_UsbScreen/releases) 页面下载对应平台的压缩包。

### Windows (win-x64)
1. 下载 `usbscreen-gui-win-x64.zip` 或 `usbscreen-cli-win-x64.zip`。
2. 解压到任意目录。
3. 运行 `UsbScreen.GUI.exe` 或 `usb-screen.exe`。

### Linux (linux-x64 / linux-arm64)
1. 下载对应架构的 `.zip` 文件。
2. 赋予运行权限: `chmod +x UsbScreen.GUI` 或 `chmod +x usb-screen`。
3. **注意**: Linux 用户请确保压缩包内的 `libSystem.IO.Ports.Native.so` 与可执行文件处于同一目录下。

---

## 🤝 致谢

*   感谢 **Mori Studio** 提供的 USB 屏幕及相关技术文档与示例。
*   UI 框架：[Avalonia](https://avaloniaui.net/)

---

## 📄 开源协议

本项目采用 [MIT License](LICENSE) 协议。

---

<div align="center">
Made with ❤️ by Blackwood
</div>
