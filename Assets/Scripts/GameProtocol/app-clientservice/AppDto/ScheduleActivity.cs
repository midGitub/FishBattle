
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 日程活动介绍 */
  public class ScheduleActivity 
  {

	public enum SeeEnum
	{
    	/** 没有看 */
    	No = 0,
    	/** 看过 */
    	Yes = 1,
	}
	public enum TaskTypeEnum
	{
    	/** 未知 */
    	Unknown = 0,
    	/** 宝图任务 */
    	Task_1 = 1,
    	/** 安全巡查 */
    	Task_2 = 2,
    	/** 日常委托 */
    	Task_3 = 3,
    	/** 四轮之塔 */
    	Task_4 = 4,
    	/** 格兰竞技场 */
    	Task_5 = 5,
    	/** 每日答题 */
    	Task_6 = 6,
    	/** 地区治安 */
    	Task_7 = 7,
    	/** 噬身之蛇 */
    	Task_8 = 8,
    	/** 远古魔兽 */
    	Task_9 = 9,
    	/** 时间之扉 */
    	Task_10 = 10,
    	/** 精英·时间之扉 */
    	Task_11 = 11,
	}
	public enum ControlTypeEnum
	{
    	/** 未知 */
    	Unknown = 0,
    	/** 全部 */
    	All = 1,
    	/** 经验 */
    	Exp = 2,
    	/** 金币 */
    	Gold = 3,
    	/** 银币 */
    	Silver = 4,
    	/** 道具 */
    	Prop = 5,
	}


    /**  */
    public int id;
    
    /** 玩法分类 */
    public int type;
    
    /** 玩法名称 */
    public string name;
    
    /** 玩法图标 */
    public string icon;
    
    /** 奖励次数 */
    public int rewardCount;
    
    /** 可持续参加类型 */
    public bool durationJoin;
    
    /** 是否推送 */
    public bool deliver;
    
    /** 推送开启 */
    public bool deliverOpen;
    
    /** 星期几开放 */
    public string openWeeks;
    
    /** 星期开放简述 */
    public string openWeeksDesc;
    
    /** 活动时间 */
    public string activityTime;
    
    /** 是否全天 */
    public bool allDay;
    
    /** 任务开始时间 */
    public List<string> openTimes;
    
    /** 是否为跨天活动 */
    public bool acrossDay;
    
    /** 跨天开始时间 */
    public List<string> startTime;
    
    /** 持续时间 */
    public List<int> duration;
    
    /** 玩家等级限制 */
    public int openGradeId;
    
    /** 参与形式 */
    public string joinType;
    
    /** 参与简述 */
    public string joinDesc;
    
    /** 玩法描述 */
    public string desc;
    
    /** 每天奖励活跃度 */
    public int activeDegree;
    
    /** 每次获得活跃度 */
    public int onceGainActive;
    
    /** 活动奖励 */
    public List<int> items;
    
    /** 弹框通知玩家 */
    public bool joinNotice;
    
    /** 寻路跳转类日程的点击后关闭日程界面:y */
    public bool pathfinding;
    
    /** 活动时间 */
    public string activityTime2;
    
    /** 后台活动Id */
    public int gameActivityId;
    
    /** 控件类型 */
    public List<int> controlType;
    
    /** 是否可找回奖励 */
    public bool rewardRegain;
    
    /** 找回奖励掉落编号 */
    public int regainFallRewardId;
    
    /** 前往参数 */
    public int smartGuideId;
    

    private FunctionOpen _openGrade;
    public  FunctionOpen openGrade{
    	get
    	{
    		if (_openGrade !=null){
				return _openGrade;
			}else{
				_openGrade = DataCache.getDtoByCls<FunctionOpen>(openGradeId);
				return _openGrade;
			}
    	}
    	set
    	{
    		_openGrade = value;
    	}
    }
    private SmartGuide _smartGuide;
    public  SmartGuide smartGuide{
    	get
    	{
    		if (_smartGuide !=null){
				return _smartGuide;
			}else{
				_smartGuide = DataCache.getDtoByCls<SmartGuide>(smartGuideId);
				return _smartGuide;
			}
    	}
    	set
    	{
    		_smartGuide = value;
    	}
    }
  }
}
