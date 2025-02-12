
### 开始使用 [How To Use]
#### 连接 [connect]
```CSharp
using POmronFinsTCP.Net;

EtherNetPLC ENT = new EtherNetPLC();
short re = ENT.Link("192.168.1.100", 9600)
if (re == 0)
    Console.WriteLine("ok");
else
    Console.WriteLine("err");
```
#### 泛型方式：读/写 [Use T:read/write]
```CSharp
//T支持的类型为：int16,int32,bool,float
ENT.GetData<T>();//读一个数据
ENT.SetData<T>();//写一个数据
ENT.GetDatas<T>();//读多个数据
ENT.SetDatas<T>();//写多个数据
```

#### 普通方式：读/写 [read/write]
```CSharp
/*所有方法返回0为成功*/
ENT.ReadWord();//读单个Int16
ENT.ReadWords();//读多个Int16
ENT.WriteWord();//写单个Int16
ENT.WriteWords();//写多个Int16
ENT.GetBitState();//读单个位
ENT.SetBitState();//写单个位
ENT.ReadReal();//读单个浮点
ENT.WriteReal();//写单个浮点
ENT.ReadInt32();//读单个Int32
ENT.WriteInt32();//写单个Int32
```