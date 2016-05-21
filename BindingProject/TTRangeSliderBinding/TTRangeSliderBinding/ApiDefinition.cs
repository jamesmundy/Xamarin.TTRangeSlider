using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace TTRangeSlider
{
	// @protocol TTRangeSliderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TTRangeSliderDelegate
	{
		// @required -(void)rangeSlider:(TTRangeSlider *)sender didChangeSelectedMinimumValue:(float)selectedMinimum andMaximumValue:(float)selectedMaximum;
		[Abstract]
		[Export ("rangeSlider:didChangeSelectedMinimumValue:andMaximumValue:")]
		void RangeSlider (TTRangeSlider sender, float selectedMinimum, float selectedMaximum);

		// @optional -(void)didEndTouchesInRangeSlider:(TTRangeSlider *)sender;
		[Export ("didEndTouchesInRangeSlider:")]
		void DidEndTouchesInRangeSlider (TTRangeSlider sender);

		// @optional -(void)didStartTouchesInRangeSlider:(TTRangeSlider *)sender;
		[Export ("didStartTouchesInRangeSlider:")]
		void DidStartTouchesInRangeSlider (TTRangeSlider sender);
	}

	// @interface TTRangeSlider : UIControl <UIGestureRecognizerDelegate>
	[BaseType (typeof(UIControl))]
	interface TTRangeSlider : IUIGestureRecognizerDelegate
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		TTRangeSliderDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TTRangeSliderDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) float minValue;
		[Export ("minValue")]
		float MinValue { get; set; }

		// @property (assign, nonatomic) float maxValue;
		[Export ("maxValue")]
		float MaxValue { get; set; }

		// @property (assign, nonatomic) float selectedMinimum;
		[Export ("selectedMinimum")]
		float SelectedMinimum { get; set; }

		// @property (assign, nonatomic) float selectedMaximum;
		[Export ("selectedMaximum")]
		float SelectedMaximum { get; set; }

		// @property (nonatomic, strong) NSNumberFormatter * numberFormatterOverride;
		[Export ("numberFormatterOverride", ArgumentSemantic.Strong)]
		NSNumberFormatter NumberFormatterOverride { get; set; }

		// @property (assign, nonatomic) BOOL hideLabels;
		[Export ("hideLabels")]
		bool HideLabels { get; set; }

		// @property (nonatomic, strong) UIColor * minLabelColour;
		[Export ("minLabelColour", ArgumentSemantic.Strong)]
		UIColor MinLabelColour { get; set; }

		// @property (nonatomic, strong) UIColor * maxLabelColour;
		[Export ("maxLabelColour", ArgumentSemantic.Strong)]
		UIColor MaxLabelColour { get; set; }

		// @property (nonatomic, strong) UIFont * minLabelFont;
		[Export ("minLabelFont", ArgumentSemantic.Strong)]
		UIFont MinLabelFont { get; set; }

		// @property (nonatomic, strong) UIFont * maxLabelFont;
		[Export ("maxLabelFont", ArgumentSemantic.Strong)]
		UIFont MaxLabelFont { get; set; }

		// @property (assign, nonatomic) BOOL disableRange;
		[Export ("disableRange")]
		bool DisableRange { get; set; }

		// @property (assign, nonatomic) float minDistance;
		[Export ("minDistance")]
		float MinDistance { get; set; }

		// @property (assign, nonatomic) float maxDistance;
		[Export ("maxDistance")]
		float MaxDistance { get; set; }

		// @property (assign, nonatomic) BOOL enableStep;
		[Export ("enableStep")]
		bool EnableStep { get; set; }

		// @property (assign, nonatomic) float step;
		[Export ("step")]
		float Step { get; set; }

		// @property (nonatomic, strong) UIImage * handleImage;
		[Export ("handleImage", ArgumentSemantic.Strong)]
		UIImage HandleImage { get; set; }

		// @property (nonatomic, strong) UIColor * handleColor;
		[Export ("handleColor", ArgumentSemantic.Strong)]
		UIColor HandleColor { get; set; }

		// @property (assign, nonatomic) CGFloat handleDiameter;
		[Export ("handleDiameter")]
		nfloat HandleDiameter { get; set; }

		// @property (assign, nonatomic) CGFloat selectedHandleDiameterMultiplier;
		[Export ("selectedHandleDiameterMultiplier")]
		nfloat SelectedHandleDiameterMultiplier { get; set; }

		// @property (nonatomic, strong) UIColor * tintColorBetweenHandles;
		[Export ("tintColorBetweenHandles", ArgumentSemantic.Strong)]
		UIColor TintColorBetweenHandles { get; set; }

		// @property (assign, nonatomic) CGFloat lineHeight;
		[Export ("lineHeight")]
		nfloat LineHeight { get; set; }
	}
}
