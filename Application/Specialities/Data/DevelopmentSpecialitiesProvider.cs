using Application.Common.Enums;

namespace Application.Specialities.Data;

public static class DevelopmentSpecialitiesProvider
{
    public static List<Speciality> ProvideSpecialities()
    {
        var specialityId = 0;
        return new List<Speciality>
        {
            new()
            {
                Id = ++specialityId,
                Code = "09.02.07",
                Name = "Информационные системы и программирование"
            },
            new()
            {
                Id = ++specialityId,
                Code = "13.02.02",
                Name = "Теплоснабжение и теплотехническое оборудование"
            },
            new()
            {
                Id = ++specialityId,
                Code = "15.02.12",
                Name = "Монтаж, техническое обслуживание и ремонт промышленного оборудования (по отраслям)"
            },
            new()
            {
                Id = ++specialityId,
                Code = "18.02.12",
                Name = "Технология аналитического контроля химических соединений"
            },
            new()
            {
                Id = ++specialityId,
                Code = "18.02.09",
                Name = "Переработка нефти и газа"
            },
            new()
            {
                Id = ++specialityId,
                Code = "20.02.01",
                Name = "Рациональное использование природохозяйственных комплексов"
            },
            new()
            {
                Id = ++specialityId,
                Code = "20.02.04",
                Name = "Пожарная безопасность",
                EntranceTest = EntranceTestType.Firefighter
            },
            new()
            {
                Id = ++specialityId,
                Code = "38.02.01",
                Name = "Экономика и бухгалтерский учет (по отраслям)"
            },
            new()
            {
                Id = ++specialityId,
                Code = "38.02.07",
                Name = "Банковское дело"
            }
        };
    }
}