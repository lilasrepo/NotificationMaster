# NotificationMaster（繁中移植版 · TC12） / Traditional-Chinese Port

> 遊戲最小化時通知你各種事件。<br>
> Notifies you about in-game events while the game is minimized.

**繁體中文**：這是 **[NotificationMaster](https://github.com/NightmareXIV/NotificationMaster)** 的繁體中文客戶端移植版，對應 **FFXIV 7.1 / yanmucorp Dalamud API12（.NET 9）**。本專案僅做相容性移植，**非官方、非原作維護**；所有原始功能與設計著作權歸原作者 **NightmareXIV**。

**English**: A Traditional-Chinese-client port of **[NotificationMaster](https://github.com/NightmareXIV/NotificationMaster)** targeting **FFXIV 7.1 / yanmucorp Dalamud API12 (.NET 9)**. Compatibility port only — **unofficial and not maintained by the original author**. All original work © **NightmareXIV**.

---

## 這是什麼 / About

當遊戲縮到背景時，針對聊天訊息、接近地圖標記、找到隊伍、過場結束、GP 回滿、登入錯誤、怪物被拉等事件發出通知。

Sends notifications for events like chat messages, approaching map flags, duty found, cutscene end, GP restored, login errors and mob pulls while the game is minimized.

## 安裝 / Installation

**繁體中文**
1. 使用 **XIVTCLauncher** 啟動繁體中文客戶端。
2. 遊戲內輸入 `/xlsettings` → 切到 **Experimental** 分頁 → **Custom Plugin Repositories（自訂插件庫）**。
3. 貼上下列網址並按 **+** 儲存：
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. 輸入 `/xlplugins`，搜尋 **NotificationMaster (TC12)** → 安裝 → 啟用。

**English**
1. Launch the Traditional-Chinese client with **XIVTCLauncher**.
2. In-game, type `/xlsettings` → **Experimental** tab → **Custom Plugin Repositories**.
3. Add this URL and save with **+**:
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. Type `/xlplugins`, search **NotificationMaster (TC12)** → Install → Enable.

## 對應版本 / Compatibility

| 項目 / Item | 版本 / Version |
|---|---|
| 遊戲 / Game | FFXIV 7.1（繁中客戶端 / TC client） |
| Dalamud | yanmucorp API12（.NET 9） |
| 移植自上游 / Ported from upstream | v2.1.1.16 |

## 原作與授權 / Credits & License

本專案 fork 自 **[NightmareXIV/NotificationMaster](https://github.com/NightmareXIV/NotificationMaster)**，授權沿用上游；所有原始功能著作權歸 **NightmareXIV**。<br>
Forked from **[NightmareXIV/NotificationMaster](https://github.com/NightmareXIV/NotificationMaster)**. License follows upstream; all original work © **NightmareXIV**.

## 免責聲明 / Disclaimer

第三方插件，使用風險自負。**移植相關問題請回報到本 repo 的 Issues，請勿打擾上游原作者。**<br>
Third-party plugin — use at your own risk. **For port-specific issues please open an Issue here; do not contact the upstream author.**
