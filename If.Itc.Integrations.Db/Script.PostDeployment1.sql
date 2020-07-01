use Integration
MERGE INTO Asset AS Target 
USING (VALUES 
('AISMLIS', 'Anti Money Laundering System', 'magnus.hogberg@if.se')
) 
AS Source (SourceAssetCode, SourceAssetName, SourceResponsibleEmail) 
ON Target.AssetCode = SourceAssetCode
-- update matched rows 
WHEN MATCHED THEN 
UPDATE SET AssetName = SourceAssetName, SourceResponsibleEmail = SourceResponsibleEmail
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (AssetCode, AssetName, ResponsibleEmail) 
VALUES (SourceAssetCode, SourceAssetName, SourceResponsibleEmail) 
--delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
DELETE;


MERGE INTO dbo.Protocol AS Target 
USING (VALUES 
('REST', 'Rest service')
) 
AS Source (SourceProtocol, SourceDescription) 
ON Target.ProtocolCode = [Description]
-- update matched rows 
WHEN MATCHED THEN 
UPDATE SET [Description] = SourceDescription
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (ProtocolCode, [Description]) 
VALUES (SourceProtocol, SourceDescription) 
--delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
DELETE;