
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 副本 */
  public class Copy 
  {

	public enum RefreshCycle
	{
    	/** 每日 */
    	Daily = 0,
    	/** 每周 */
    	Weekly = 1,
	}


    /**  */
    public int id;
    
    /** 副本名称 */
    public string name;
    
    /** 描述 */
    public string desc;
    
    /** 最少玩家人数 */
    public int minPlayer;
    
    /** 最小等级 */
    public int minGrade;
    
    /** 服务器开放等级 */
    public int serverGrade;
    
    /** 刷新周期 */
    public int refreshId;
    
    /** 任务id */
    public int missionId;
    
    /** 所在场景 */
    public int sceneId;
    
    /** 模型ID */
    public int modelId;
    
    /** 奖励物品ID */
    public List<int> rewardIds;
    
    /** 是否需要确认 */
    public bool confirm;
    
    /** 任务数 */
    public int count;
    
    /** 退出副本进入场景 */
    public int existToSceneId;
    
    /**  */
    public int existToX;
    
    /**  */
    public int existToY;
    
    /**  */
    public int existToZ;
    
    /**  */
    public int scheduleActivity;
    

  }
}
