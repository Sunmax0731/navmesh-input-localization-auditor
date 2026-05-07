# 要件定義

| 項目 | 内容 |
| --- | --- |
| Rank | 69 |
| Domain | UnityEditor |
| Idea No. | 7 |
| Repository | navmesh-input-localization-auditor |
| 主な公開先 | GitHub Release / BOOTH |

## 背景

専門設定は異常に気づくまで時間がかかる。

## 目的

NavMesh Bake、InputAction、Localization Tableを用途別に検査する。 入力、確認、履歴保存、次アクションを同じ作業単位で扱えるようにする。

## 必須要件

- Unity audit target を複数件まとめて検証できる。
- required fields: `id`, `title`, `scenePath`, `navMeshProfile`, `inputAction`, `localeKey`。
- warning field: `fallbackLocale`。
- 代表シナリオ、QCDS metrics、docs ZIP、release evidence を再生成できる。
