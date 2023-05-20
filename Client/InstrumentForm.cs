﻿using Client.Cards;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Client;

public partial class InstrumentForm : Form
{
    private readonly AppDbContext context = new AppDbContext(Program.ContextOptions);
    MainForm mainForm;
    private List<Instrument> Instruments;
    private readonly InstrumentTypeEnum InstrumentType;

    public InstrumentForm(InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All, MainForm mainForm = null)
    {
        InstrumentType = instrumentType;
        InitializeComponent();
        this.mainForm = mainForm;
    }

    public static string GetInstrumentTypeName(InstrumentTypeEnum instrumentType)
    {
        switch (instrumentType)
        {
            case InstrumentTypeEnum.Rezci:
                return "Резцы";
            case InstrumentTypeEnum.Protyazhki:
                return "Протяжки";
            case InstrumentTypeEnum.Frezi:
                return "Фрезы";
            case InstrumentTypeEnum.RolikiRezb:
                return "Ролики резьбонакатные";
            case InstrumentTypeEnum.Zenkeri:
                return "Зенкеры";
            case InstrumentTypeEnum.Metchiki:
                return "Метчики";
            case InstrumentTypeEnum.Razvertki:
                return "Развертки";
            case InstrumentTypeEnum.InstrumentMechKreplenie:
                return "Инструмент с механическим креплением";
            default:
                return "";
        }
    }

    private void InstrumentForm_Load(object sender, EventArgs e)
    {
        this.ControlBox = false;

        SetPath(InstrumentType);

        GetInstruments(InstrumentType);
        PopulateInstruments();
    }

    private void PopulateInstruments()
    {
        Instruments.ForEach(instrument =>
        {
            var instrumentCard = new InstrumentCard(instrument, this.InstrumentType);
            instrumentCard.DeleteInstrument += InstrumentCard_DeleteInstrument;
            instrumentsContainer.Controls.Add(instrumentCard);
        });
    }

    private void InstrumentCard_DeleteInstrument(InstrumentCard instrumentCard)
    {
        var instrument = context.Instruments.FirstOrDefault(x => x.Id == instrumentCard.Instrument.Id);
        if (instrument != null)
        {
            try
            {
                context.Instruments.Remove(instrument);
                context.SaveChanges();

                instrumentsContainer.Controls.Remove(instrumentCard);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при удалении инструмента", "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void GetInstruments(InstrumentTypeEnum instrumentType)
    {
        var data = context.Instruments.AsNoTracking().Include(x => x.InstrumentType).Include(x => x.Gost);
        if (instrumentType == InstrumentTypeEnum.All)
        {
            Instruments = data.ToList();
        }
        else
        {
            Instruments = data.Where(x => x.InstrumentTypeId == (int)instrumentType).ToList();
        }
    }

    public void SetPath(InstrumentTypeEnum instrumentType)
    {
        if (instrumentType != InstrumentTypeEnum.All)
        {
            labelType.Visible = true;
            labelType.Text = "/ " + GetInstrumentTypeName(instrumentType);
        }
    }

    private void InstrumentForm_MouseLeave(object sender, EventArgs e)
    {

    }

    private void pictureButtonAdd_Click(object sender, EventArgs e)
    {
        mainForm.addInstrument_Click(sender, e);
    }
}
