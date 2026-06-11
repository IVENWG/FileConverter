# LessMB Converter

**LessMB Converter** 是一款轻量级文件格式转换工具，集成在 Windows 右键菜单中，两步即可完成文件转换与压缩。

---

## 安装

1. 下载安装包 `LessMBConverter-x.x-x64-setup.msi`
2. 双击运行安装程序
3. 安装完成后，右键菜单中即可使用

> 需要 .NET Framework 4.8，安装程序会自动检测并提示安装。

---

## 使用方法

### 基本用法

```
选中文件（或文件夹）→ 右键 → LessMB Converter → 选择目标格式
```

就是这么简单！转换完成后，转换的文件会出现在源文件旁边。

### 示例

| 操作 | 步骤 |
|------|------|
| PNG 转 JPG | 右键图片 → LessMB Converter → **To Jpg** |
| MP4 转 MP3（提取音频） | 右键视频 → LessMB Converter → **To Mp3** |
| WAV 转 MP3（压缩） | 右键音频 → LessMB Converter → **To Mp3** |
| Word 转 PDF | 右键文档 → LessMB Converter → **To Pdf** |
| 批量转换 | 选中多个文件 → 右键 → LessMB Converter → 选择格式 |

### 批量转换

按住 `Ctrl` 或 `Shift` 选中多个文件，右键选择转换格式，所有文件将依次转换。

### 转换进度

转换开始后，主窗口会显示每个文件的转换进度和预估剩余时间。转换完成后窗口自动关闭。

---

## 设置

双击桌面快捷方式或在开始菜单中打开 **LessMB Converter Settings** 进入设置界面。

### 转换预设

预设定义了输入格式到输出格式的转换规则。你可以：

- **添加预设**：点击 `+` 按钮，选择输入格式和输出格式
- **修改预设**：选中预设后调整参数（质量、分辨率、编码器等）
- **删除预设**：选中预设后点击 `-` 按钮
- **导入/导出预设**：方便在不同电脑间共享配置

### 常用预设参数

| 参数 | 说明 |
|------|------|
| 输出格式 | 目标文件格式（png、mp4、mp3 等） |
| 质量/码率 | 输出质量，数值越高画质越好、文件越大 |
| 分辨率 | 缩放比例（25%、50%、75%、100%） |
| 帧率 | 视频每秒帧数 |
| 硬件加速 | 启用 NVIDIA NVENC 或 AMD AMF 加速视频编码 |

### 输出路径模板

在设置中可以自定义转换后文件的保存路径和命名规则：

| 模板变量 | 含义 | 示例 |
|----------|------|------|
| `{Name}` | 源文件名 | `photo` |
| `{Extension}` | 输出格式扩展名 | `jpg` |
| `{Directory}` | 源文件目录 | `C:\Photos` |
| `{Index}` | 序号（批量时） | `1` |

默认模板：`{Directory}\{Name}.{Extension}`（保存在源文件同目录）

### 转换后操作

可以为每个预设设置转换完成后的操作：
- **无操作** — 仅转换
- **删除源文件** — 转换成功后删除原文件
- **移到回收站** — 转换成功后将原文件放入回收站

---

## 支持的格式

### 图片
| 输入 | 输出 |
|------|------|
| png, jpg, bmp, gif, tiff, webp, avif, svg, ico | png, jpg, gif, ico, bmp, webp, avif |

### 音频
| 输入 | 输出 |
|------|------|
| mp3, wav, ogg, flac, aac, wma | mp3, wav, ogg, flac, aac, wma |

### 视频
| 输入 | 输出 |
|------|------|
| mp4, avi, mkv, webm, wmv, flv, mov, 3gp | mp4, mkv, avi, webm, wmv, flv, gif, mp3, wav, ogg |

### 文档
| 输入 | 输出 |
|------|------|
| pdf, doc/docx, xls/xlsx, ppt/pptx | pdf |

### 其他
| 输入 | 输出 |
|------|------|
| 光盘音轨 (CDA) | mp3, wav, ogg, flac, aac, wma |

---

## 常见问题

### 右键菜单中没有 LessMB Converter

1. 打开 **LessMB Converter Settings**
2. 如果弹出注册提示，点击确认注册 Shell 扩展
3. 或以管理员身份运行命令行：
   ```
   FileConverter.exe --register-shell-extension "安装路径\FileConverterExtension.dll"
   ```

### 转换失败

- 确认输入文件格式受支持
- 尝试调低输出质量/分辨率
- 查看转换日志（主窗口中的日志按钮）

### 视频转换很慢

在预设设置中启用**硬件加速**（需要 NVIDIA 或 AMD 显卡支持）。

### 卸载

通过 Windows 设置 → 应用 → 找到 LessMB Converter → 卸载

---

## 编译

### 环境要求

- Visual Studio 2022（或 Build Tools）
- .NET Framework 4.8 Developer Pack
- Wix 5（仅编译安装包时需要）

### 编译命令

```bash
# 恢复 NuGet 包
msbuild FileConverter.sln /t:Restore

# 编译 Release 版本
msbuild FileConverter.sln /t:Build /p:Configuration=Release /p:Platform=x64
```

### 输出文件

- 主程序：`Application/FileConverter/bin/x64/Release/FileConverter.exe`
- Shell 扩展：`Application/FileConverterExtension/bin/x64/Release/FileConverterExtension.dll`

---

## License

MIT License
