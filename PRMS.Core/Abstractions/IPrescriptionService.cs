﻿using PRMS.Core.Dtos;
using PRMS.Domain.Enums;

namespace PRMS.Core.Abstractions;

public interface IPrescriptionService
{
    public Task<Result> CreatePrescription(string patientUserId, string physicianUserId,
        CreatePrescriptionDto prescriptionDto);
    public Task<Result<PaginatorDto<IEnumerable<PrescribedMedicationDto>>>> GetPatiencePrescribedMedicationHistory(string patientUserId, PaginationFilter paginationFilter);
    public Task<Result<PrescribedMedicationDto>> GetPrescribedMedicationHistoryById(string medicationId);
    public Task<Result> UpdatePrescription(string medicationId, MedicationStatus medicationStatus);
}