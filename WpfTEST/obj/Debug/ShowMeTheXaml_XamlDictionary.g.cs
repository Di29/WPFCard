
using System.Collections.Generic;

namespace ShowMeTheXAML
{
    public static class XamlDictionary
    {
        static XamlDictionary()
        {
            XamlResolver.Set("cards_1", @"<smtx:XamlDisplay Key=""cards_1"" Margin=""4 4 0 0"" VerticalContentAlignment=""Top"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""200"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid.RowDefinitions>
        <RowDefinition Height=""140"" />
        <RowDefinition Height=""*"" />
        <RowDefinition Height=""Auto"" />
      </Grid.RowDefinitions>
      <Image Source=""Resources/Dias.jpg"" Height=""140"" Width=""196"" Stretch=""UniformToFill"" />
      <Button Grid.Row=""0"" Style=""{StaticResource MaterialDesignFloatingActionMiniAccentButton}"" HorizontalAlignment=""Right"" VerticalAlignment=""Bottom"" Margin=""0 0 16 -20"">
        <materialDesign:PackIcon Kind=""Account"" />
      </Button>
      <StackPanel Grid.Row=""1"" Margin=""8 24 8 0"">
        <TextBlock FontWeight=""Bold"">About Me</TextBlock>
        <TextBlock TextWrapping=""Wrap"" VerticalAlignment=""Center"">Уринбасаров Диас. 29.01.2000 года рождения. Детсво провел в городе Экибастуз. Студент ЖД колледжа и компьютерной академий ШАГ. </TextBlock>
      </StackPanel>
      <StackPanel HorizontalAlignment=""Right"" Grid.Row=""2"" Orientation=""Horizontal"" Margin=""8"">
        <Button Style=""{StaticResource MaterialDesignToolButton}"" Width=""30"" Padding=""2 0 2 0"" materialDesign:RippleAssist.IsCentered=""True"">
          <materialDesign:PackIcon Kind=""ShareVariant"" />
        </Button>
        <Button Style=""{StaticResource MaterialDesignToolButton}"" Width=""30"" Padding=""2 0 2 0"" materialDesign:RippleAssist.IsCentered=""True"">
          <materialDesign:PackIcon Kind=""Heart"" />
        </Button>
      </StackPanel>
    </Grid>
  </materialDesign:Card>
</smtx:XamlDisplay>");
        }
    }
}