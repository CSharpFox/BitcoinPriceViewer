# 🪙 Bitcoin Live Price Tracker  
### 🔥 Real-time BTC price tracker with ASP.NET Core Razor Pages

[![.NET](https://img.shields.io/badge/.NET-8.0-purple?logo=dotnet)](https://dotnet.microsoft.com/)  
[![License: MIT](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)  

---

## 🚀 Overview

A lightweight and beginner-friendly **ASP.NET Core Razor Pages** project that:
- Fetches real-time Bitcoin prices from [CoinGecko API](https://www.coingecko.com/en/api/documentation)
- Updates automatically every 30 seconds via AJAX
- Shows data in a clean, responsive **Bootstrap 5 UI**
- Contains zero database dependencies  
> 💡 Perfect for beginners learning `HttpClient`, `JsonDocument`, and Razor Pages.

---

## ✨ Features

| Feature                   | Description                                |
|---------------------------|--------------------------------------------|
| 🔌 Live API Call          | Fetches price from CoinGecko               |
| ⚙️ JSON Parsing           | Uses `System.Text.Json` and `JsonDocument` |
| 💻 Razor Pages            | Simple structure, easy to follow           |
| 🎨 Beautiful UI           | Bootstrap 5 based card component           |
| 🔄 Auto Refresh           | JavaScript Fetch + `setInterval()`         |
| 📦 No DB Required         | Stateless, no setup, plug & play           |

---

## 🧰 Tech Stack

```txt
Framework : ASP.NET Core 8.0
Frontend  : Razor Pages + Bootstrap 5 + JS (Fetch API)
API       : CoinGecko
Tooling   : Visual Studio / VS Code
```

---

## ⚙️ Getting Started

### 📦 Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or VS Code

### 🛠️ Installation

```bash
git clone https://github.com/CSharpFox/BitcoinPriceViewer.git
cd BitcoinPriceViewer
dotnet run
```

Then navigate to `https://localhost:5001`.

---

## 🗂 Project Structure

```
BitcoinPriceViewer/
├── Pages/
│   ├── Index.cshtml          # UI showing the price
│   ├── Index.cshtml.cs       # PageModel for index
│   ├── Price.cshtml          # Dummy Razor page (used for AJAX)
│   └── Price.cshtml.cs       # Returns JSON price from service
│
├── Services/
│   └── PriceService.cs       # Calls CoinGecko and parses JSON
│
├── Shared/
│   └── _Layout.cshtml        # Bootstrap loaded here
```

---

## 📡 API Reference

We use the following CoinGecko API:

```http
GET https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd
```

Example Response:
```json
{
  "bitcoin": {
    "usd": 69420.00
  }
}
```

---

## 📃 License

MIT License — see the [LICENSE](LICENSE) file.

---

## 🦊 Author

Made with ❤️ by [**CSHARPFoX**](https://www.youtube.com/@CSharpFox)  
Follow for more real-world C#/.NET mini-projects!

---

### ☕ Like the project?
Leave a ⭐ on GitHub, it helps a lot!