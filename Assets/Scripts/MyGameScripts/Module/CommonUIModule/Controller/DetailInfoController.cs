﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : xush
// Created : 7/2/2017 6:12:38 PM
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using System.Collections.Generic;
using AppDto;
using UnityEngine;
using System;

/// <summary>
/// This is the controller class for module DetailInfo, use this to control the ui or view , such as it's init , update or dispose.
/// @xush in 7/2/2017 6:12:38 PM
/// </summary>
public class DetailInfoController : MonoViewController<DetailInfoView>
{
	private string[] _crewTitleStr = {"","物理属性", "魔法属性", "辅助属性", "异常抗性", "魔法抗性"};
    private int developHeight = 3;  //强化效果垂直距离
    private int developWidth = 0;   //强化效果水平距离
    public static Comparison<CharacterPropertyDto> _comparison = null;

    /// <summary>
    /// 界面就绪后初始化，一个UI生命周期只会执行一次
    /// </summary>
    protected override void AfterInitView ()
    {
    }

    //添加事件监听 在gameeventlistener和eventlistener中添加的回调不需要自己remove，所以没有一个相应的RemoveCustomEvent函数
	protected override void RegistCustomEvent ()
    {
    }

    //收到界面销毁后的回收处理，比如引用置空等
    protected override void OnDispose()
    {
    }

    //伙伴特有的 or人物属性title
    public void SetTitleInfo(string title, CharacterPropertyDto infoList=null)
    {
        InitTitle(title);
        List<CharacterPropertyDto> dataList = new List<CharacterPropertyDto>();
        dataList.Insert(0, infoList);
        dataList.Insert(1, null);   //为了对齐 xush
        InitAttr(dataList, false);
    }
    
    //伙伴or人物高级属性
    public void SetCrewDetailInfo(List<CharacterAbility> characterList, 
		List<CharacterPropertyDto> dataList=null)
	{

		int index = -1;     //记录标题
        List<CharacterAbility> dtolist = new List<CharacterAbility>();
        List<CharacterPropertyDto> propertyDtos = new List<CharacterPropertyDto>();
        CharacterPropertyDto dto2 = null;
        int remainder = 0;   //两列 以余数为remainder判断换行

        characterList.ForEachI((data,idx) =>
		{
			if (data.type != index && index < _crewTitleStr.Length)
			{
                index = data.type;
                InitTitle(_crewTitleStr[index]);
            }

            if (idx % 2 == remainder)
		    {
		        dtolist.Add(data);
		        if (idx + 1 < characterList.Count)
		        {
                    if (characterList[idx + 1].type == index)
                    {
                        dtolist.Add(characterList[idx + 1]);
                        if (dataList != null)
                            dto2 = dataList.Find(d => d.propId == characterList[idx + 1].id);
                        else   
                            dto2 = ModelManager.Player.GetPropertyDtoById(characterList[idx + 1].id);
                    }
                    else
                        remainder = remainder > 0 ? 0 : 1;
                }

                CharacterPropertyDto dto1 = null;
                if (dataList != null)
                    dto1 = dataList.Find(d => d.propId == data.id);
                else
                    dto1 = ModelManager.Player.GetPropertyDtoById(data.id);

                if (dto1 != null)
                    propertyDtos.Add(dto1);
		        if (dto2 != null)
		            propertyDtos.Add(dto2);

                InitAttr(dtolist, propertyDtos);
            }

            propertyDtos.Clear();
            dtolist.Clear();
		});
	}
	

	public void InitTitle(string title)
	{
		var com = AddChild<TitleLbController, TitleLbView>(
			_view.Table_UITable.gameObject
			, TitleLbView.Name);
		
		com.SetInfo(title);
	}

	private void InitAttr(List<CharacterPropertyDto> dtoList, bool isPercent = true)
	{
	    if (dtoList == null || dtoList.Count == 0) return;

        var con = AddChild<AttrLabelUnitedController, AttrLabelUnited>(
            _view.Table_UITable.gameObject
            , AttrLabelUnited.NAME);

        con.SetInfo(dtoList, isPercent);
	}

    public  void SetEffectLb( int listcount, List<CharacterPropertyDto> list, List<CharacterPropertyDto> properList)
    {
        View.Table_UITable.padding.x = developWidth;
        View.Table_UITable.padding.y = developHeight;
        List<DevelopEffectLbController> EffectList = new List<DevelopEffectLbController>();
        for (int i = 0; i < listcount; i++)
        {
            var com = AddChild<DevelopEffectLbController, DevelopEffectLb>(
            View.Table_UITable.gameObject
            , DevelopEffectLb.NAME);
            EffectList.Add(com);
        }
        EffectList.ForEachI((item, index) =>
        {
            List<CharacterPropertyDto> sortList = PropertyListSort(list);
            properList.ForEach(data =>
            {
                if (data.propId == sortList[index].propId)
                {
                    item.SetItemInfo(sortList[index],data.propValue);
                }
            });
            
        });
    }

    private static List<CharacterPropertyDto> PropertyListSort(List<CharacterPropertyDto> dict)
    {
        if (_comparison == null)
        {
            _comparison = (a, b) =>
            {
                return a.propId.CompareTo(b.propId);
            };
        }
        dict.Sort(_comparison);
        return dict;
    }

    private void InitAttr(IEnumerable<CharacterAbility> dtoList, 
        IEnumerable<CharacterPropertyDto> propertyDtos)
    {
        if (dtoList == null) return;

        var con = AddChild<AttrLabelUnitedController, AttrLabelUnited>(
            _view.Table_UITable.gameObject
            , AttrLabelUnited.NAME);

        con.SetInfo(dtoList, propertyDtos);
    }

    public void SetPosition(Vector3 pos)
    {
        _view.BackGround_Transform.transform.localPosition = pos;
        var scrollviewPos = new Vector3(pos.x, pos.y+30, 0);
        _view.ScrollView_UIScrollView.transform.localPosition = scrollviewPos;
    }
}
