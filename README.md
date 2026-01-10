# MarkItDownX

## 公開手順

1. `releases` ブランチにリリース用の変更をコミットします。
2. `releases` ブランチへ push すると、GitHub Actions の「Velopack リリース」ワークフローが実行されます。
3. ワークフローが Velopack でパッケージ（`vpk`）を作成し、GitHub Releases にアップロードします。

※ `main` ブランチへの push では公開は実行されません。

## 配布/運用メモ

- 初回インストールは Velopack が生成する `Setup.exe` を配布します。
- GitHub Releases には `artifacts/releases` フォルダに生成されたファイル一式をアップロードします（`Setup.exe` を含む一式）。
