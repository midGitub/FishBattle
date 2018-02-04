
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 交易商品 */
  public class TradeGoods 
  {

	public enum TradeLabelEnum
	{
    	/** 无标签 */
    	None = 0,
    	/** 热卖 */
    	Hot = 1,
    	/** 新品 */
    	New = 2,
    	/** vip限购 */
    	VipLimit = 3,
    	/** X折 */
    	Discount = 4,
	}


    /** 物品编号 */
    public int id;
    
    /** 同类组前一编号，没有的为0 */
    public int preId;
    
    /** 交易菜单编号 */
    public int tradeMenuId;
    
    /** 基础数量 */
    public int baseAmount;
    
    /** 基础价格 */
    public int basePrice;
    
    /** 税率 */
    public float taxRate;
    
    /** 是否在售（玩家从系统购买） */
    public bool sale;
    
    /** 是否能出售（玩家卖到系统） */
    public bool sell;
    
    /** 开放服务器等级 */
    public int gameServerGrade;
    
    /** 有效最高服务器等级 */
    public int maxGameServerGrade;
    
    /** 标准系数 */
    public float factor;
    
    /** 涨价系数 */
    public float riseFactor;
    
    /** 每天涨跌限制 */
    public float priceLimit;
    
    /** 最高出售价 */
    public int maxSalePrice;
    
    /** 最低出售价 */
    public int minSalePrice;
    
    /** 标签编号 */
    public int labelId;
    
    /** 标签参数 */
    public string labelParams;
    
    /** 每日补货 */
    public int dailyAmount;
    
    /** 价格根据基础物品 */
    public bool baseItem;
    
    /** 基础ID */
    public int baseId;
    
    /** 基础数量 */
    public int baseCount;
    

  }
}
