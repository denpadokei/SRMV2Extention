# SRMV2Extention

[![Build and Release](https://github.com/denpadokei/SRMV2Extention/actions/workflows/build-and-release.yml/badge.svg)](https://github.com/denpadokei/SRMV2Extention/actions/workflows/build-and-release.yml)

SongRequestManagerV2 に独自のチャットコマンドを追加するための拡張テンプレート MOD です。サンプルとして 4 つのコマンドを実装しています。

## 機能

- SongRequestManagerV2 のコマンド基盤 (`SRMCommandBase`) を継承したコマンドを追加するためのテンプレート
- `!denpadokei` でチャットに「テストです from <ユーザー名>」と返信
- `!denpadokei1` `!denpadokei2` `!denpadokei3` はログ出力だけを行うサンプルコマンド
- 追加したコマンドは Zenject のインストーラで `ISRMCommand` として登録される
- すべて `FlagParameter.Everyone` で登録されており、誰でも実行できる

## 動作環境

| 項目 | 内容 |
| --- | --- |
| Beat Saber | 1.12.2 |
| 依存 MOD | BSIPA 4.1.3 |

この MOD は SongRequestManagerV2 の API を参照してビルドされており、動作には SongRequestManagerV2 (CI では 14.0.1) と SiraUtil が必要です。

## インストール

1. Beat Saber を 1.12.2 に合わせる (BSManager などのバージョン管理ツールを推奨)
2. BSIPA と上記の依存 MOD (SongRequestManagerV2 を含む) をインストールする
3. [Releases](https://github.com/denpadokei/SRMV2Extention/releases) から `SRMV2Extention-0.0.1-bs1.12.2.zip` をダウンロードし、`Plugins` フォルダをゲームフォルダへ上書きコピーする

## 使い方

SongRequestManagerV2 を導入した状態で、Twitch チャットから次のコマンドを送ります。

| コマンド | 動作 |
| --- | --- |
| `!denpadokei` | チャットに「テストです from <ユーザー名>」を返す |
| `!denpadokei1` | ログにメッセージを出力 (サンプル) |
| `!denpadokei2` | ログにメッセージを出力 (サンプル) |
| `!denpadokei3` | ログにメッセージを出力 (サンプル) |

自分でコマンドを追加する場合は、`SRMV2Extention/Models/SRMExtentionCommand.cs` の `Constractor` と `SRMV2Extention/Installer/SRMExtentionInstaller.cs` の `CreateCommand` を編集してください。

## ビルド

```powershell
git clone https://github.com/denpadokei/SRMV2Extention.git
cd SRMV2Extention
dotnet build .\SRMV2Extention\SRMV2Extention.csproj -c Release
```

`BeatSaberDir` (または `GameDirectory`) に Beat Saber のインストール先を設定すると、ゲームの参照アセンブリを解決できます。既定では `..\Refs` フォルダが参照先になります。

GitHub Actions の `build-and-release.yml` が push ごとにビルドし、`X.X.X` 形式のタグを push するとリリースを作成します。

## ライセンス

MIT
