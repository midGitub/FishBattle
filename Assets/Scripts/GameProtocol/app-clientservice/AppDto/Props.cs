
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /**  */
  public class Props : AppItem
  {

	public enum ScopeEnum
	{
    	/** 无限制 */
    	All = 0,
    	/** 战斗 */
    	Battle = 1,
    	/** 背包 */
    	Backpack = 2,
    	/** 擂台战斗中使用 */
    	ArenaBattle = 3,
	}
	public enum RelationTypeEnum
	{
    	Unknow = 0,
    	/** 1寿命 */
    	Life = 1,
    	/** 2经验 */
    	Exp = 2,
    	/** 3资质 */
    	Rarity = 3,
    	/** 4物品 */
    	Item = 4,
	}


    /** 功能介绍 */
    public string introduction;
    
    /** 应用范围 */
    public int scopeId;
    
    /** 使用最小等级 */
    public int minGrade;
    
    /** 使用最大等级 */
    public int maxGrade;
    
    /** 逻辑编号 */
    public int logicId;
    
    /** 使用者类型(战斗中) */
    public int triggerType;
    
    /** 使用目标类型(战斗中) */
    public int targetType;
    
    /** 是否复活目标 */
    public bool reliveTarget;
    
    /** 自动使用 */
    public bool autoApply;
    
    /** 对应npc对话功能id */
    public int dialogFunctionId;
    
    /** 堆叠全部使用 */
    public bool surperposition;
    
    /** 客户端用[1-寿命 2-经验 3-资质 4-物品] */
    public int relationType;
    
    /** 如果玩家还在战斗, 不能调用背包使用接口(0默认可以,1禁止) */
    public bool forbiddenInFighting;
    
    /** 不能移动到仓库标记 */
    public bool forbiddenToWarehouse;
    
    /** 等级 */
    public int grade;
    
    /** 道具参数基类，具体为其子类 */
    public PropsParam propsParam;
    

  }
}
