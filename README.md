# POmronFinsTCP.Net

### 欧姆龙plc通信FINS协议的实现。此项目是OmronFinsTCP.Net的分支。
##### This is a protocol for communicating with Omron PLCs. 
#

### 拷贝的原项目：[Copy to：]
### https://github.com/iHomeSoft/OmronFinsTCP.Net
#

### 下载包 [download、install]
```CSharp
Install-Package POmronFinsTCP.Net
```
#

### 列子:[ensample code:]
```CSharp
FinsDebuger/Form1.cs
```
#

### 开始使用 [How To Use]
#### 连接 [connect]
```CSharp
using OmronFinsTCP.Net;

EtherNetPLC ENT = new EtherNetPLC();
short re = ENT.Link("192.168.1.100", 9600);
if (re == 0)
    Console.WriteLine("ok");
else
    Console.WriteLine("err");
```

#### 读/写 [read/write]
```CSharp
short re = ENT.ReadWords(PlcMemory.DM, short.Parse(1000), short.Parse(count), out rd);
```
#
### 版本记录：[version history]
###### *表示部分代码可能与前版本不兼容 [*For some code is incompatible with previous versions]
## v3.0.0
###### 1.拷贝项目，并升级到新的Net支持 [Copy project,New Net support]

