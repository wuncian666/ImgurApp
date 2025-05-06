Collecting workspace information# ImgurApp

ImgurApp 是一個 Windows Forms 應用程式，讓使用者能夠與 Imgur 平台互動，包括瀏覽相簿、上傳圖片、管理評論等功能。

## 功能介紹

- 瀏覽 Imgur 圖庫內容
- 上傳影片與圖片
- 管理個人相簿
- 查看和新增評論
- 為內容投票 (上/下投票)
- 為相簿加入到我的最愛

## 安裝與設定

### 相依套件

- .NET Framework 4.7.2
- Newtonsoft.Json (已包含在專案的套件資料夾中)
- AutoMapper

### 必要設定

1. 您必須擁有 Imgur API 金鑰才能使用此應用程式。請參考 [Imgur API 文件](https://apidocs.imgur.com/) 註冊並取得 API 金鑰。

2. 在專案根目錄建立或修改 `app.config` 檔案，填入您的 API 金鑰：

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
    <appSettings>
        <add key="token" value="您的 API 金鑰" />
    </appSettings>
</configuration>
```

## 使用說明

1. 執行應用程式後，主畫面會顯示 Imgur 圖庫的熱門內容
2. 使用上方選單可以切換瀏覽模式和排序方式
3. 點擊「相簿」選項可查看您的相簿
4. 使用「相片上傳」功能可以上傳新圖片
5. 點擊任何圖片可查看詳細資訊和評論

## 專案架構

ImgurApp 使用 MVP (Model-View-Presenter) 架構模式：

- **Model**: 資料模型和 API 互動類別
- **View**: 使用者介面元件和表單
- **Presenter**: 處理業務邏輯和協調 Model 與 View 的互動

### 主要元件

- **GalleryForm**: 主要應用程式視窗
- **ImageEditForm**: 圖片編輯和管理
- **CommentComponent**: 評論顯示和互動
- **VoteComponent**: 投票功能

## 開發者資訊

這個應用程式使用 C# 和 Windows Forms 開發，展示了如何與 Imgur API 互動，以及如何建構具有良好架構的桌面應用程式。

## 已知問題和限制

- 需要網際網路連線才能正常運作
- 依賴 Imgur API 的限制和配額
- 尚未支援某些進階功能如影片上傳

## 授權

Copyright © 2025