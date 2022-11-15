using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ParkingAPI.Contracts.Parking;
using ParkingAPI.Infrastructure.Repository;

namespace ParkingAPI.AppServices.Services.Parking
{

    public class ParkingService : IParkingService
    {
        private readonly IRepository<Domain.Entities.Parking> _parkingRepository;
        private readonly IMapper _mapper;

        public ParkingService(IRepository<Domain.Entities.Parking> parkingRepository, IMapper mapper)
        {
            _parkingRepository = parkingRepository;
            _mapper = mapper;
        }


        /// <inheritdoc />
        public async Task<List<ParkingDTO>> GetAllPost()
        {
            var result = await _parkingRepository.GetAll().OrderBy(p => p.Address)
                .ToListAsync();

            return result.Count > 0 ? _mapper.Map<List<ParkingDTO>>(result) : new List<ParkingDTO>();
        }

        public Task AddAsync(ParkingDTO model)
        {
            var post = _mapper.Map<Domain.Entities.Parking>(model);
            return _parkingRepository.AddAsync(post);
        }

        public async Task<ParkingDTO> Update(ParkingDTO model)
        {
            var post = _mapper.Map<Domain.Entities.Parking>(model);
            await _parkingRepository.UpdateAsync(post);
            return _mapper.Map<ParkingDTO>(post);
        }

        public async Task DeleteAsync(Guid id)
        {
            var post = await _parkingRepository.GetByIdAsync(id);
            if (post == null)
            {
                throw new Exception($"There is no parking with id : {id}");
            }

            await _parkingRepository.DeleteAsync(post);
        }
    }
}