using System;

namespace KeyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Object o = new object();
            o?.Equals(0);
        }
    }
}

/**
 * C#的关键字
 * 一、保留关键字
 * 
 * abstract	as		bool	break	byte	case
 * catch	char		class	    const	continue
 * default	do	double	else	    enum
 * extern	false		float	    for
 * foreach	goto	    if	        int
 * interface	long	namespace	new
 * null	    operator    out         override	
 * private	protected	public		return	sbyte
 * short	sizeof		static	    string	struct
 * switch	this	    throw	    true	try	   typeof	uint
 * ulong	ushort	    using	    virtual	void
 * while
 * 
 * base 基类指针
 * checked 溢出检查
 * decimal 28-29个有效位 ,如果希望实数被视为 decimal 类型，请使用后缀 m 或 M
 * delegate 委托关键字
 * event 事件关键字
 * explicit 显式类型转换
 * implicit 隐式类型转换
 * finally try-catch-finally
 * fixed 固化内存为指针 防止再分配
 * in foreach中使用或者 修饰函数参数作为入参会被读取
 * out 作为出参 仅仅写 不会读 
 * ref 读写权限
 * internal 本项目使用 不可导出
 * is 类型判断
 * lock 相当于JAVA的synchronized关键字，用于产生一个同步代码块
 * object Object a = new object();在 Object 类中提供了 4 个常用的方法，即 Equals、GetHashCode、GetType 以及 ToString 
 * params 和in out ref一样是方法参数,修饰一维数组，表示可变参数，必须放在最后，一个方法只可以有一个可变参数 
 * sealed 先当与JAVA和c++中的final
 * readonly 区别于const的编译期替换,readonly是实时读取
 * stackalloc 相当于c的malloc，仅在不安全代码块中使用
 * struct 是值类型 没有构造函数不可继承 不能new
 * unchecked 可以越界溢出
 * volatile 防止编译器优化，以及直接读写内存值
 * unsafe 和 Rust的unsafe类似，在不安全代码块中可以进行一些危险操作如指针等，把安全性交给程序员手中
 * 
 * 二、上下文关键字
 *  add	        自定义事件访问器
 *  alias
 *  ascending	声明式编程，查询表达式
 *  async       与python、Rust、TS等语言一样，定义一个异步方法，直接调用立即返回一个promise对象，与await搭配则直接同步获取值
 *  descending	声明式编程，查询表达式
 *  dynamic	    动态引用类型，不进行编译时类型检测
 *  from	    声明式编程，查询表达式
 *  get         属性的读操作 
 *  global	    全局命名空间
 *  group	    声明式编程，查询表达式
 *  into	    声明式编程，查询表达式
 *  join	    声明式编程，查询表达式
 *  let	        声明式编程，查询表达式
 *  orderby	    声明式编程，查询表达式
 *  partial     将一个类拆开到不同的文件中进行定义
 *  remove	    定义一个自定义事件访问器，客户端代码取消订阅事件时会调用该访问器
 *  select	    声明式编程，查询表达式
 *  set         属性的写操作 
 *  
 */



