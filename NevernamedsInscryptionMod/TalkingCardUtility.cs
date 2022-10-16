using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace TalkingCardUtility
{
	public static class TextureLoadUtility
    {
		public static Sprite ConvertTexToSprite(Texture2D tex, Vector2? pivot = null)
		{
			Vector2 actualPivot = new Vector2(0.5f, 0.5f);
			if (pivot != null)
			{
				actualPivot = new Vector2(pivot.Value.x, pivot.Value.y);
			}
			tex.filterMode = FilterMode.Point;
			Sprite texSprite1 = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), actualPivot, 100.0f);
			return texSprite1;
		}
		public static Texture2D LoadTex(string path)
		{
			byte[] imgBytes = ExtractEmbeddedResource(path);
			Texture2D tex = new Texture2D(2, 2);
			tex.LoadImage(imgBytes);
			tex.filterMode = FilterMode.Point;
			return tex;
		}
		public static byte[] ExtractEmbeddedResource(String filePath)
		{
			filePath = filePath.Replace("/", ".");
			filePath = filePath.Replace("\\", ".");
			var baseAssembly = Assembly.GetCallingAssembly();
			using (Stream resFilestream = baseAssembly.GetManifestResourceStream(filePath))
			{
				if (resFilestream == null)
				{
					return null;
				}
				byte[] ba = new byte[resFilestream.Length];
				resFilestream.Read(ba, 0, ba.Length);
				return ba;
			}
		}
	}
    public static class DialogueEventGenerator
    {
        public static DialogueEvent GenerateEvent(string name, List<CustomLine> mainLines, List<List<CustomLine>> repeatLines, DialogueEvent.MaxRepeatsBehaviour afterMaxRepeats)
        {
            DialogueEvent ev = new DialogueEvent();
            List<DialogueEvent.Speaker> speakers = new List<DialogueEvent.Speaker> { DialogueEvent.Speaker.Single };
            ev.id = name;
            ev.mainLines = new DialogueEvent.LineSet(mainLines.ConvertAll((x) => x.ToLine(speakers)));
            ev.repeatLines = repeatLines.ConvertAll((x) => new DialogueEvent.LineSet(x.ConvertAll((x2) => x2.ToLine(speakers))));
            ev.maxRepeatsBehaviour = afterMaxRepeats;
            ev.speakers = new List<DialogueEvent.Speaker>(speakers);
            DialogueDataUtil.Data?.events?.Add(ev);
            return ev;
        }
    }
	public class CustomLine
	{
		public DialogueEvent.Line ToLine(List<DialogueEvent.Speaker> speakers)
		{
			if (!speakers.Contains(speaker))
			{
				speakers.Add(speaker);
			}
			return new DialogueEvent.Line
			{
				p03Face = p03Face,
				emotion = emotion,
				letterAnimation = letterAnimation,
				speakerIndex = speakers.IndexOf(speaker),
				text = text ?? "",
				specialInstruction = specialInstruction ?? "",
				storyCondition = storyCondition,
				storyConditionMustBeMet = storyConditionMustBeMet,
			};
		}

		public static implicit operator CustomLine(string str)
		{
			return new CustomLine { text = str };
		}

		public static implicit operator CustomLine((string, TextDisplayer.LetterAnimation, Emotion) param)
		{
			return new CustomLine { text = param.Item1, emotion = param.Item3, letterAnimation = param.Item2 };
		}

		public static implicit operator CustomLine((string, TextDisplayer.LetterAnimation) param)
		{
			return new CustomLine { text = param.Item1, letterAnimation = param.Item2 };
		}

		public static implicit operator CustomLine((string, TextDisplayer.LetterAnimation, DialogueEvent.Speaker) param)
		{
			return new CustomLine { text = param.Item1, speaker = param.Item3, letterAnimation = param.Item2 };
		}

		public static implicit operator CustomLine((string, TextDisplayer.LetterAnimation, DialogueEvent.Speaker, Emotion) param)
		{
			return new CustomLine { text = param.Item1, speaker = param.Item3, letterAnimation = param.Item2, emotion = param.Item4 };
		}

		public static implicit operator CustomLine((string, Emotion) param)
		{
			return new CustomLine { text = param.Item1, emotion = param.Item2 };
		}

		public static implicit operator CustomLine((string, Emotion, DialogueEvent.Speaker) param)
		{
			return new CustomLine { text = param.Item1, speaker = param.Item3, emotion = param.Item2 };
		}

		public static implicit operator CustomLine((string, DialogueEvent.Speaker) param)
		{
			return new CustomLine { text = param.Item1, speaker = param.Item2 };
		}

		public P03AnimationController.Face p03Face;
		public Emotion emotion;
		public TextDisplayer.LetterAnimation letterAnimation;
		public DialogueEvent.Speaker speaker;
		public string text;
		public string specialInstruction;
		public StoryEvent storyCondition = StoryEvent.BasicTutorialCompleted;
		public bool storyConditionMustBeMet;
	}
}