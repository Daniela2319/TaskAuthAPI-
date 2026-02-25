using FluentAssertions;
using trilha_Api_TIVIT.DTO.TarefasDTO;
using trilha_Api_TIVIT.Mappers;
using trilha_Api_TIVIT.Models;
using trilha_Api_TIVIT.Models.Enum;

namespace trilha_Api_TIVIT.Tests
{
    public class TarefaMapperTests
    {
        private readonly TarefaMapper _mapper;

        public EnumStatusTarefa Finalizado { get; private set; }
        public EnumStatusTarefa Pendente { get; private set; }

        public TarefaMapperTests()
        {
            _mapper = new TarefaMapper();
        }

        // ================================
        // Model -> DTO
        // ================================

        [Fact]
        public void ToResponse_ShouldConvertTarefaToTarefaDTO()
        {
            var entity = new Tarefa
            {
                Id = 1,
                Titulo = "Estudar .NET",
                Descricao = "Revisar testes unitários",
                Status = EnumStatusTarefa.Pendente,
                DataCriacao = new DateTime(2026, 02, 23)
            };

            var result = _mapper.ToResponse(entity);

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(entity);
        }

        [Fact]
        public void ToResponse_NullTarefaShouldReturnNull()
        {
            Tarefa entity = null;

            var result = _mapper.ToResponse(entity);

            result.Should().BeNull();
        }

        // ================================
        // List Model -> List DTO
        // ================================

        [Fact]
        public void ToResponseList_ShouldConvertTarefaListToDTOList()
        {
            var entityList = new List<Tarefa>
            {
                new Tarefa
                {
                    Id = 1,
                    Titulo = "Tarefa 1",
                    Descricao = "Descricao 1",
                    Status = Pendente
                },
                new Tarefa
                {
                    Id = 2,
                    Titulo = "Tarefa 2",
                    Descricao = "Descricao 2",
                    Status = Finalizado
                }
            };

            var result = _mapper.ToResponseList(entityList);

            result.Should().NotBeNull();
            result.Should().HaveCount(2);
            result[0].Titulo.Should().Be("Tarefa 1");
            result[1].Status.Should().Be(Finalizado);
        }

        [Fact]
        public void ToResponseList_NullListShouldReturnNull()
        {
            List<Tarefa> entityList = null;

            var result = _mapper.ToResponseList(entityList);

            result.Should().BeNull();
        }

        // ================================
        // PostDTO -> Model
        // ================================

        [Fact]
        public void ToModel_ShouldConvertPostDTOToTarefa()
        {
            var dto = new TarefaPostRequestDTO
            {
                Titulo = "Nova tarefa",
                Descricao = "Descricao nova"
            };

            var result = _mapper.ToModel(dto);

            result.Should().NotBeNull();
            result.Titulo.Should().Be(dto.Titulo);
            result.Descricao.Should().Be(dto.Descricao);
        }

        [Fact]
        public void ToModel_NullPostDTOShouldReturnNull()
        {
            TarefaPostRequestDTO dto = null;

            var result = _mapper.ToModel(dto);

            result.Should().BeNull();
        }

        // ================================
        // PutDTO -> Update Model
        // ================================

        [Fact]
        public void ToModelPut_ShouldUpdateExistingTarefa()
        {
            var entity = new Tarefa
            {
                Id = 1,
                Titulo = "Antigo",
                Descricao = "Descricao antiga",
                Status = Pendente
            };

            var dto = new TarefaPutRequestDTO
            {
                Id = 1,
                Titulo = "Atualizado",
                Descricao = "Descricao atualizada",
                Status = Finalizado
            };

            _mapper.ToModelPut(entity, dto);

            entity.Titulo.Should().Be(dto.Titulo);
            entity.Descricao.Should().Be(dto.Descricao);
            entity.Status.Should().Be(dto.Status);
        }
    }
}