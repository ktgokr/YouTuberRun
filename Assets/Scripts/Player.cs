using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using EnunTypes;

public class Player : MonoBehaviour
{
    [Header("Change")]
    public Theme ChannelType = Theme.None;
    public Country CountryType = Country.none;
    [SerializeField] Image ThumbnailImage_;
    public Image thumbnailImage {set{ThumbnailImage_ = value;}get {return ThumbnailImage_;}}
    [SerializeField] TextMeshProUGUI ThumbNail;
    public TextMeshProUGUI thumbnail{set{ThumbNail = value;}get {return ThumbNail;}}
    

     public Theme ChanelTheme(Theme theme)
    {
        ChannelType = theme;
        return ChannelType;
    }
}
